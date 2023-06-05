namespace StreamingPlatform
{
    partial class MovieDetails
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieDetails));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.ExitBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MovieName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MoviePicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.AgeRate = new System.Windows.Forms.Label();
            this.IMDbRate = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ReleaseDate = new System.Windows.Forms.Label();
            this.Length = new System.Windows.Forms.Label();
            this.Genres = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.DeleteMovieBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.AddToWatchlistBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.mediaPlayer = new StreamingPlatform.MediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 300;
            this.guna2BorderlessForm1.BorderRadius = 50;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.ExitBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(26)))), ((int)(((byte)(76)))));
            this.ExitBtn.HoverState.FillColor = System.Drawing.Color.DarkRed;
            this.ExitBtn.IconColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(535, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.PressedColor = System.Drawing.Color.DarkRed;
            this.ExitBtn.Size = new System.Drawing.Size(55, 36);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MovieName
            // 
            this.MovieName.Font = new System.Drawing.Font("Calisto MT", 18.25F, System.Drawing.FontStyle.Bold);
            this.MovieName.ForeColor = System.Drawing.Color.White;
            this.MovieName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MovieName.Location = new System.Drawing.Point(11, 438);
            this.MovieName.Name = "MovieName";
            this.MovieName.Size = new System.Drawing.Size(475, 39);
            this.MovieName.TabIndex = 4;
            this.MovieName.Text = "Venom: Let There Be Carnage 2021";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 36);
            this.panel1.TabIndex = 5;
            // 
            // MoviePicture
            // 
            this.MoviePicture.BorderRadius = 15;
            this.MoviePicture.FillColor = System.Drawing.Color.Transparent;
            this.MoviePicture.Image = ((System.Drawing.Image)(resources.GetObject("MoviePicture.Image")));
            this.MoviePicture.ImageRotate = 0F;
            this.MoviePicture.Location = new System.Drawing.Point(4, 489);
            this.MoviePicture.Name = "MoviePicture";
            this.MoviePicture.Size = new System.Drawing.Size(259, 197);
            this.MoviePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MoviePicture.TabIndex = 7;
            this.MoviePicture.TabStop = false;
            // 
            // AgeRate
            // 
            this.AgeRate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeRate.ForeColor = System.Drawing.Color.White;
            this.AgeRate.Location = new System.Drawing.Point(426, 488);
            this.AgeRate.Name = "AgeRate";
            this.AgeRate.Size = new System.Drawing.Size(152, 28);
            this.AgeRate.TabIndex = 4;
            this.AgeRate.Text = "Age Rating: PG-13";
            // 
            // IMDbRate
            // 
            this.IMDbRate.AutoSize = true;
            this.IMDbRate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IMDbRate.ForeColor = System.Drawing.Color.White;
            this.IMDbRate.Location = new System.Drawing.Point(509, 527);
            this.IMDbRate.Name = "IMDbRate";
            this.IMDbRate.Size = new System.Drawing.Size(49, 20);
            this.IMDbRate.TabIndex = 4;
            this.IMDbRate.Text = "5.9/10";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Black;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(447, 511);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(60, 52);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 8;
            this.guna2PictureBox2.TabStop = false;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReleaseDate.ForeColor = System.Drawing.Color.White;
            this.ReleaseDate.Location = new System.Drawing.Point(265, 488);
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.Size = new System.Drawing.Size(152, 28);
            this.ReleaseDate.TabIndex = 4;
            this.ReleaseDate.Text = "Release: 2021";
            this.ReleaseDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Length
            // 
            this.Length.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Length.ForeColor = System.Drawing.Color.White;
            this.Length.Location = new System.Drawing.Point(265, 523);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(152, 28);
            this.Length.TabIndex = 4;
            this.Length.Text = "Length: 132min";
            this.Length.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Genres
            // 
            this.Genres.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genres.ForeColor = System.Drawing.Color.White;
            this.Genres.Location = new System.Drawing.Point(265, 566);
            this.Genres.Name = "Genres";
            this.Genres.Size = new System.Drawing.Size(313, 45);
            this.Genres.TabIndex = 4;
            this.Genres.Text = "Genres: Action, Sci-Fi, Thriller";
            // 
            // Description
            // 
            this.Description.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.Description.ForeColor = System.Drawing.Color.White;
            this.Description.Location = new System.Drawing.Point(265, 613);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(313, 78);
            this.Description.TabIndex = 4;
            this.Description.Text = "Description: Eddie Brock struggles to adjust to his new life as the host of the a" +
    "lien symbiote Venom, which grants him super-human abilities in order to be a let" +
    "hal vigilante.";
            // 
            // DeleteMovieBtn
            // 
            this.DeleteMovieBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteMovieBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteMovieBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteMovieBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteMovieBtn.FillColor = System.Drawing.Color.DarkRed;
            this.DeleteMovieBtn.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteMovieBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteMovieBtn.Location = new System.Drawing.Point(543, 432);
            this.DeleteMovieBtn.Name = "DeleteMovieBtn";
            this.DeleteMovieBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.DeleteMovieBtn.Size = new System.Drawing.Size(45, 45);
            this.DeleteMovieBtn.TabIndex = 9;
            this.DeleteMovieBtn.Text = "X";
            this.DeleteMovieBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DeleteMovieBtn.Click += new System.EventHandler(this.DeleteMovieBtn_Click);
            // 
            // AddToWatchlistBtn
            // 
            this.AddToWatchlistBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddToWatchlistBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddToWatchlistBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddToWatchlistBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddToWatchlistBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(126)))));
            this.AddToWatchlistBtn.Font = new System.Drawing.Font("Rockwell", 15.75F);
            this.AddToWatchlistBtn.ForeColor = System.Drawing.Color.White;
            this.AddToWatchlistBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddToWatchlistBtn.Image")));
            this.AddToWatchlistBtn.ImageSize = new System.Drawing.Size(28, 28);
            this.AddToWatchlistBtn.Location = new System.Drawing.Point(492, 432);
            this.AddToWatchlistBtn.Name = "AddToWatchlistBtn";
            this.AddToWatchlistBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.AddToWatchlistBtn.Size = new System.Drawing.Size(45, 45);
            this.AddToWatchlistBtn.TabIndex = 9;
            this.AddToWatchlistBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AddToWatchlistBtn.Click += new System.EventHandler(this.AddToWatchlistBtn_Click);
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.mediaPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(126)))));
            this.mediaPlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.mediaPlayer.Location = new System.Drawing.Point(0, 36);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.Size = new System.Drawing.Size(590, 394);
            this.mediaPlayer.TabIndex = 6;
            // 
            // MovieDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(26)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(590, 700);
            this.Controls.Add(this.AddToWatchlistBtn);
            this.Controls.Add(this.DeleteMovieBtn);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.MoviePicture);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.IMDbRate);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.ReleaseDate);
            this.Controls.Add(this.AgeRate);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Genres);
            this.Controls.Add(this.MovieName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MovieDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MovieDetails";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MoviePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox ExitBtn;
        private System.Windows.Forms.Panel panel1;
        private MediaPlayer mediaPlayer;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2CircleButton DeleteMovieBtn;
        private Guna.UI2.WinForms.Guna2CircleButton AddToWatchlistBtn;
        public System.Windows.Forms.Label MovieName;
        public System.Windows.Forms.Label IMDbRate;
        public System.Windows.Forms.Label AgeRate;
        public System.Windows.Forms.Label Length;
        public System.Windows.Forms.Label ReleaseDate;
        public System.Windows.Forms.Label Description;
        public System.Windows.Forms.Label Genres;
        public Guna.UI2.WinForms.Guna2PictureBox MoviePicture;
    }
}