namespace Modplay
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnPlay = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.barProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.lblProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSong = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLink = new System.Windows.Forms.ToolStripStatusLabel();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblVolume = new System.Windows.Forms.Label();
            this.txtAbout = new System.Windows.Forms.RichTextBox();
            this.isFavorite = new System.Windows.Forms.CheckBox();
            this.playFavorites = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(12, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(87, 28);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play/Next";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barProgress,
            this.lblProgress,
            this.lblSong,
            this.lblLink});
            this.statusStrip1.Location = new System.Drawing.Point(0, 155);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(566, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // barProgress
            // 
            this.barProgress.Name = "barProgress";
            this.barProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // lblProgress
            // 
            this.lblProgress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblProgress.Size = new System.Drawing.Size(10, 17);
            // 
            // lblSong
            // 
            this.lblSong.IsLink = true;
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(292, 17);
            this.lblSong.Spring = true;
            this.lblSong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSong.Click += new System.EventHandler(this.lblSong_Click);
            // 
            // lblLink
            // 
            this.lblLink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblLink.IsLink = true;
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(147, 17);
            this.lblLink.Text = "github.com/wex/modplay";
            this.lblLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLink.Click += new System.EventHandler(this.lblLink_Click);
            // 
            // trackVolume
            // 
            this.trackVolume.LargeChange = 2;
            this.trackVolume.Location = new System.Drawing.Point(105, 12);
            this.trackVolume.Maximum = 40;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackVolume.Size = new System.Drawing.Size(45, 133);
            this.trackVolume.TabIndex = 6;
            this.trackVolume.TickFrequency = 2;
            this.trackVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackVolume.Value = 40;
            this.trackVolume.Scroll += new System.EventHandler(this.trackVolume_Scroll);
            this.trackVolume.ValueChanged += new System.EventHandler(this.trackVolume_ValueChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 117);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 28);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblVolume
            // 
            this.lblVolume.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(67, 71);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(32, 13);
            this.lblVolume.TabIndex = 8;
            this.lblVolume.Text = "-0 dB";
            this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAbout
            // 
            this.txtAbout.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbout.Location = new System.Drawing.Point(156, 12);
            this.txtAbout.Name = "txtAbout";
            this.txtAbout.ReadOnly = true;
            this.txtAbout.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtAbout.Size = new System.Drawing.Size(398, 133);
            this.txtAbout.TabIndex = 9;
            this.txtAbout.Text = "";
            this.txtAbout.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.txtAbout_LinkClicked);
            // 
            // isFavorite
            // 
            this.isFavorite.Appearance = System.Windows.Forms.Appearance.Button;
            this.isFavorite.Location = new System.Drawing.Point(12, 43);
            this.isFavorite.Name = "isFavorite";
            this.isFavorite.Size = new System.Drawing.Size(87, 25);
            this.isFavorite.TabIndex = 10;
            this.isFavorite.Text = "Star";
            this.isFavorite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.isFavorite.UseVisualStyleBackColor = true;
            this.isFavorite.CheckedChanged += new System.EventHandler(this.isFavorite_CheckedChanged);
            // 
            // playFavorites
            // 
            this.playFavorites.Appearance = System.Windows.Forms.Appearance.Button;
            this.playFavorites.Location = new System.Drawing.Point(12, 87);
            this.playFavorites.Name = "playFavorites";
            this.playFavorites.Size = new System.Drawing.Size(87, 28);
            this.playFavorites.TabIndex = 11;
            this.playFavorites.Text = "Randomize";
            this.playFavorites.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playFavorites.UseVisualStyleBackColor = true;
            this.playFavorites.CheckedChanged += new System.EventHandler(this.playFavorites_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 177);
            this.Controls.Add(this.playFavorites);
            this.Controls.Add(this.isFavorite);
            this.Controls.Add(this.txtAbout);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.trackVolume);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modplay Alpha";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar barProgress;
        private System.Windows.Forms.ToolStripStatusLabel lblLink;
        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripStatusLabel lblProgress;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.RichTextBox txtAbout;
        private System.Windows.Forms.ToolStripStatusLabel lblSong;
        private System.Windows.Forms.CheckBox isFavorite;
        private System.Windows.Forms.CheckBox playFavorites;
    }
}

