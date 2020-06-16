using System;
using System.Windows.Forms;
using System.Net;
using Un4seen.Bass;
using System.Collections.Generic;
using System.IO;

namespace Modplay
{
    public partial class frmMain : Form
    {
        List<string> favorites = new List<string>();

        int stream;
        int song = 1;
        int favoriteIndex = 0;
        float _gainAmplification = 1;
        Random rand;
        BASSTimer _updateTimer;
        private DSPPROC myDSPAddr = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtAbout.Rtf = @"{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fnil\fcharset0 Calibri;}}
\viewkind4\uc1\pard\sa200\sl240\slmult1\lang11\b\f0\fs20 Modplay\b0  powered by\par
\pard\sa200\sl240\slmult1\tx1704 The Mod Archive\tab https://modarchive.org/\line BASS \tab https://www.un4seen.com/\line ZXTUNE \tab https://zxtune.bitbucket.io/\line BASSZXTUNE \tab https://sourceforge.net/projects/basszxtune/\par
Source available: \tab https://github.com/wex/modplay\par
}";

            try
            {
                favorites.Clear();

                foreach (String t in File.ReadAllLines(@"favorites.txt"))
                {
                    favorites.Add(t);
                }
            } catch (Exception) {}

            if (!Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_LATENCY, this.Handle))
            {
                MessageBox.Show("Initializing audio buffer failed!");
                Application.Exit();
            }

            Bass.BASS_PluginLoad("basszxtune.dll");

            SetVolume(trackVolume.Maximum, trackVolume.Maximum);

            rand = new Random();

            _updateTimer = new BASSTimer(100);
            _updateTimer.Tick += new EventHandler(timerUpdate_Tick);

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _updateTimer.Tick -= new EventHandler(timerUpdate_Tick);

            Bass.BASS_Stop();
            Bass.BASS_Free();

            using (TextWriter tw = new StreamWriter("favorites.txt", false))
            {
                favorites.ForEach(s =>
                {
                    tw.WriteLine(s);
                });

                tw.Close();
            }
        }

        private void SetVolume(int v, int max)
        {
            lblVolume.Text = $"{v - max} dB";
            _gainAmplification = (float)Math.Pow(10d, (double) (v - max) / 20d);
        }

        unsafe private void MyDSPGainUnsafe(int handle, int channel, IntPtr buffer, int length, IntPtr user)
        {
            if (_gainAmplification == 1f || length == 0 || buffer == IntPtr.Zero)
                return;

            int l4 = length / 4;

            float* data = (float*)buffer;
            for (int a = 0; a < l4; a++)
            {
                *data = *data * _gainAmplification;
                data++;
            }
        }

        private void addFavorite(int id)
        {
            favorites.Add($"{id}");
        }

        private void removeFavorite(int id)
        {
            favorites.Remove($"{id}");
        }

        private bool isFavorited(int id)
        {
            return (favorites.IndexOf($"{id}") >= 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _updateTimer.Stop();
            Bass.BASS_StreamFree(stream);

            if (favorites.Count > 0 && playFavorites.Checked)
            {
                song = int.Parse(favorites[favoriteIndex]);
                favoriteIndex++;

                if (favoriteIndex >= favorites.Count)
                {
                    favoriteIndex = 0;
                }
            } else
            {
                song = rand.Next(1, 189357);
            }

            isFavorite.Checked = isFavorited(song);

            using (var client = new WebClient())
            {
                client.DownloadFile($@"https://api.modarchive.org/downloads.php?moduleid={song}", "song.tmp");
            }

            lblSong.Text = $"Mod Archive #{song}";
            lblSong.Tag = song;

            stream = Bass.BASS_StreamCreateFile(@"song.tmp", 0, 0, BASSFlag.BASS_SAMPLE_FLOAT | BASSFlag.BASS_STREAM_PRESCAN);

            myDSPAddr = new DSPPROC(MyDSPGainUnsafe);
            Bass.BASS_ChannelSetDSP(stream, myDSPAddr, IntPtr.Zero, 2);

            Bass.BASS_ChannelPlay(stream, true);
            _updateTimer.Start();
        }

        private void timerUpdate_Tick(object sender, System.EventArgs e)
        {
            if (Bass.BASS_ChannelIsActive(stream) == BASSActive.BASS_ACTIVE_PLAYING)
            {
                
            }
            else
            {
                _updateTimer.Stop();
                button1_Click(sender, e);
                return;
            }

            long pos = Bass.BASS_ChannelGetPosition(stream);
            long len = Bass.BASS_ChannelGetLength(stream);
            double totaltime = Bass.BASS_ChannelBytes2Seconds(stream, len);
            double elapsedtime = Bass.BASS_ChannelBytes2Seconds(stream, pos);

            lblProgress.Text = String.Format("{0:#0.00} / {1:#0.00}", Utils.FixTimespan(elapsedtime, "MMSS"), Utils.FixTimespan(totaltime, "MMSS"));
            barProgress.Maximum = (int)totaltime;
            barProgress.Value = (int)elapsedtime;
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/wex/modplay");
        }

        private void trackVolume_Scroll(object sender, EventArgs e)
        {

        }

        private void trackVolume_ValueChanged(object sender, EventArgs e)
        {
            SetVolume(trackVolume.Value, trackVolume.Maximum);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtAbout_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void lblSong_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"https://modarchive.org/index.php?request=view_by_moduleid&query={lblSong.Tag}");
        }

        private void isFavorite_CheckedChanged(object sender, EventArgs e)
        {
            if (!isFavorite.Checked)
            {
                isFavorite.Text = "Star";
                removeFavorite(song);
            } else
            {
                isFavorite.Text = "Unstar";
                addFavorite(song);
            }

        }

        private void playFavorites_CheckedChanged(object sender, EventArgs e)
        {
            if (playFavorites.Checked)
            {
                playFavorites.Text = "Starred";
            } else
            {
                playFavorites.Text = "Randomize";
            }
        }
    }
}
