using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.Devices;

namespace StreamingPlatform
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        bool openstate = true;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kg462\Desktop\StreamingPlatform\StreamingPlatform\Database.mdf;Integrated Security=True");
        int picplace = 1;
        DataTable HighlightImages= new DataTable();

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            HighightPanel.Hide();
            MoviesList.Hide();
            if (openstate == false)
            {
                openstate = true;
                SideMenu.Size = new Size(295, 565);
                MoviesList.Padding = new Padding(37, 5, 0, 0);
            }
            else
            {
                openstate = false;
                SideMenu.Size = new Size(70, 565);
                MoviesList.Padding = new Padding(0, 0, 0, 0);
            }
            HighightPanel.Show();
            MoviesList.Show();
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (picplace < 5) HighightPanel.BackgroundImage = GetImage((byte[])HighlightImages.Rows[picplace++][0]);
            else {
                picplace = 0;
                HighightPanel.BackgroundImage = GetImage((byte[])HighlightImages.Rows[picplace++][0]); }
            timer1.Start();
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (picplace>0) HighightPanel.BackgroundImage = GetImage((byte[])HighlightImages.Rows[picplace--][0]);
            else
            {
                picplace = 4;
                HighightPanel.BackgroundImage = GetImage((byte[])HighlightImages.Rows[picplace--][0]);
            }
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "select Name,Picture from MovieTb";
            ShowMovies(query);

            query = "select Top 5 Picture from MovieTb order by IMDbRating DESC";
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(HighlightImages);
            con.Close();
            HighightPanel.BackgroundImage = GetImage((byte[])HighlightImages.Rows[0][0]);
            timer1.Start();
        }

        void ShowMovies(string query) {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MoviesList.Controls.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MovieInfo movie = new MovieInfo();
                movie.MovieName.Text = dt.Rows[i][0].ToString();
                movie.MoviePicture.Image = GetImage((byte[])dt.Rows[i][1]);
                movie.Parent = MoviesList;
            }
            con.Close();
        }
        private static Image GetImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return (Image.FromStream(ms));
            }
        }

        private void guna2ImageButton4_MouseEnter(object sender, EventArgs e)
        {
            RightNav.ShadowDecoration.Enabled = true;
        }

        private void guna2ImageButton4_MouseLeave(object sender, EventArgs e)
        {
            RightNav.ShadowDecoration.Enabled = false;
        }

        private void guna2ImageButton3_MouseEnter(object sender, EventArgs e)
        {
            LeftNav.ShadowDecoration.Enabled = true;
        }

        private void guna2ImageButton3_MouseLeave(object sender, EventArgs e)
        {
            LeftNav.ShadowDecoration.Enabled = false;
        }

        private void UserSettings_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                UserMenu.Show(UserSettings, e.Location);
            }
        }

        private void enterAdminPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.ShowDialog();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string query = "select Name,Picture from MovieTb where Name like '%" + SearchBox.Text + "%'";
            ShowMovies(query);
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            string query = "select Name,Picture from MovieTb";
            ShowMovies(query);
        }

        private void Top10Btn_Click(object sender, EventArgs e)
        {
            string query = "select top 10 Name,Picture from MovieTb Order by IMDbRating DESC";
            ShowMovies(query);
        }

        private void MoviesBtn_Click(object sender, EventArgs e)
        {
            string query = "select Name,Picture from MovieTb where ShowType = 'Movie'";
            ShowMovies(query);
        }

        private void TVshowsBtn_Click(object sender, EventArgs e)
        {
            string query = "select Name,Picture from MovieTb where ShowType = 'TV-Show'";
            ShowMovies(query);
        }

        private void WatchlistBtn_Click(object sender, EventArgs e)
        {
            string query = "select Name,Picture from MovieTb Join watchlist on MovieTb.Name = watchlist.MovieName where watchlist.UserID = '"+LoginForm.UserID+"'";
            ShowMovies(query);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            HighightPanel.BackgroundImage = GetImage((byte[])HighlightImages.Rows[picplace++][0]);
            if (picplace==5)picplace= 0;
        }

        private void ManageProfileToolStrip_Click(object sender, EventArgs e)
        {
            ManageProfile manageProfile = new ManageProfile();
            string query = "select * from UserTb where ID= '" + LoginForm.UserID + "'";
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            manageProfile.UserName.Text = dt.Rows[0][1].ToString();
            manageProfile.AccountType.Text = dt.Rows[0][2].ToString();
            manageProfile.Email.Text = dt.Rows[0][3].ToString();
            manageProfile.Passwordtxt.Text = dt.Rows[0][4].ToString();
            con.Close();
            manageProfile.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (openstate == false) {
                MenuBtn.PerformClick();
            }
            SearchBox.Focus();
        }
    }
}
