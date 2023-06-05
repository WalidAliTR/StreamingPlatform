namespace StreamingPlatform
{
    partial class MediaPlayer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaPlayer));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.PlaypauseBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.StopBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.VolumeBar = new System.Windows.Forms.TrackBar();
            this.MuteBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.VideoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.FullscreenBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ShowTrailer = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // PlaypauseBtn
            // 
            this.PlaypauseBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.PlaypauseBtn.HoverState.ImageSize = new System.Drawing.Size(44, 44);
            this.PlaypauseBtn.Image = ((System.Drawing.Image)(resources.GetObject("PlaypauseBtn.Image")));
            this.PlaypauseBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.PlaypauseBtn.ImageRotate = 0F;
            this.PlaypauseBtn.ImageSize = new System.Drawing.Size(43, 43);
            this.PlaypauseBtn.Location = new System.Drawing.Point(237, 342);
            this.PlaypauseBtn.Name = "PlaypauseBtn";
            this.PlaypauseBtn.PressedState.ImageSize = new System.Drawing.Size(43, 43);
            this.PlaypauseBtn.Size = new System.Drawing.Size(48, 40);
            this.PlaypauseBtn.TabIndex = 1;
            this.PlaypauseBtn.Click += new System.EventHandler(this.PlaypauseBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.StopBtn.HoverState.ImageSize = new System.Drawing.Size(44, 44);
            this.StopBtn.Image = ((System.Drawing.Image)(resources.GetObject("StopBtn.Image")));
            this.StopBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.StopBtn.ImageRotate = 0F;
            this.StopBtn.ImageSize = new System.Drawing.Size(43, 43);
            this.StopBtn.Location = new System.Drawing.Point(308, 342);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.PressedState.ImageSize = new System.Drawing.Size(43, 43);
            this.StopBtn.Size = new System.Drawing.Size(48, 40);
            this.StopBtn.TabIndex = 1;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // VolumeBar
            // 
            this.VolumeBar.Location = new System.Drawing.Point(473, 338);
            this.VolumeBar.Maximum = 100;
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Size = new System.Drawing.Size(104, 45);
            this.VolumeBar.TabIndex = 2;
            this.VolumeBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.VolumeBar.Scroll += new System.EventHandler(this.VolumeBar_Scroll);
            // 
            // MuteBtn
            // 
            this.MuteBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.MuteBtn.HoverState.ImageSize = new System.Drawing.Size(36, 36);
            this.MuteBtn.Image = ((System.Drawing.Image)(resources.GetObject("MuteBtn.Image")));
            this.MuteBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.MuteBtn.ImageRotate = 0F;
            this.MuteBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.MuteBtn.Location = new System.Drawing.Point(436, 338);
            this.MuteBtn.Name = "MuteBtn";
            this.MuteBtn.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.MuteBtn.Size = new System.Drawing.Size(44, 45);
            this.MuteBtn.TabIndex = 3;
            this.MuteBtn.Click += new System.EventHandler(this.MuteBtn_Click);
            // 
            // VideoPlayer
            // 
            this.VideoPlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.VideoPlayer.Enabled = true;
            this.VideoPlayer.Location = new System.Drawing.Point(0, 0);
            this.VideoPlayer.Name = "VideoPlayer";
            this.VideoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoPlayer.OcxState")));
            this.VideoPlayer.Size = new System.Drawing.Size(590, 332);
            this.VideoPlayer.TabIndex = 0;
            this.VideoPlayer.MouseMoveEvent += new AxWMPLib._WMPOCXEvents_MouseMoveEventHandler(this.VideoPlayer_MouseMoveEvent);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "pause.png");
            this.imageList1.Images.SetKeyName(1, "play.png");
            this.imageList1.Images.SetKeyName(2, "mute.png");
            this.imageList1.Images.SetKeyName(3, "sound.png");
            // 
            // FullscreenBtn
            // 
            this.FullscreenBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.FullscreenBtn.HoverState.ImageSize = new System.Drawing.Size(44, 44);
            this.FullscreenBtn.Image = ((System.Drawing.Image)(resources.GetObject("FullscreenBtn.Image")));
            this.FullscreenBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.FullscreenBtn.ImageRotate = 0F;
            this.FullscreenBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.FullscreenBtn.Location = new System.Drawing.Point(45, 342);
            this.FullscreenBtn.Name = "FullscreenBtn";
            this.FullscreenBtn.PressedState.ImageSize = new System.Drawing.Size(43, 43);
            this.FullscreenBtn.Size = new System.Drawing.Size(48, 40);
            this.FullscreenBtn.TabIndex = 1;
            this.FullscreenBtn.Click += new System.EventHandler(this.FullscreenBtn_Click);
            // 
            // ShowTrailer
            // 
            this.ShowTrailer.BackColor = System.Drawing.Color.Transparent;
            this.ShowTrailer.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ShowTrailer.HoverState.ImageSize = new System.Drawing.Size(103, 103);
            this.ShowTrailer.Image = ((System.Drawing.Image)(resources.GetObject("ShowTrailer.Image")));
            this.ShowTrailer.ImageOffset = new System.Drawing.Point(0, 0);
            this.ShowTrailer.ImageRotate = 0F;
            this.ShowTrailer.ImageSize = new System.Drawing.Size(100, 100);
            this.ShowTrailer.Location = new System.Drawing.Point(-1, 0);
            this.ShowTrailer.Name = "ShowTrailer";
            this.ShowTrailer.PressedState.ImageSize = new System.Drawing.Size(100, 100);
            this.ShowTrailer.Size = new System.Drawing.Size(590, 394);
            this.ShowTrailer.TabIndex = 10;
            this.ShowTrailer.Click += new System.EventHandler(this.ShowTrailer_Click);
            // 
            // MediaPlayer
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(126)))));
            this.Controls.Add(this.ShowTrailer);
            this.Controls.Add(this.MuteBtn);
            this.Controls.Add(this.VolumeBar);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.FullscreenBtn);
            this.Controls.Add(this.PlaypauseBtn);
            this.Controls.Add(this.VideoPlayer);
            this.Name = "MediaPlayer";
            this.Size = new System.Drawing.Size(590, 394);
            this.Load += new System.EventHandler(this.MediaPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ImageButton MuteBtn;
        private System.Windows.Forms.TrackBar VolumeBar;
        private Guna.UI2.WinForms.Guna2ImageButton PlaypauseBtn;
        public AxWMPLib.AxWindowsMediaPlayer VideoPlayer;
        private System.Windows.Forms.ImageList imageList1;
        private Guna.UI2.WinForms.Guna2ImageButton FullscreenBtn;
        public Guna.UI2.WinForms.Guna2ImageButton StopBtn;
        public Guna.UI2.WinForms.Guna2ImageButton ShowTrailer;
    }
}
