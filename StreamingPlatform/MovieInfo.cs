using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Guna.UI2.WinForms.Suite;
using System.IO;

namespace StreamingPlatform
{
    public partial class MovieInfo : UserControl
    {
        public MovieInfo()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kg462\Desktop\StreamingPlatform\StreamingPlatform\Database.mdf;Integrated Security=True");

        int FormWidth = 280, FormHeight = 235,PictureHeight=150;

        private void MoviePicture_Click(object sender, EventArgs e)
        {
            this.Size = new Size(FormWidth-4, FormHeight-4);
            MoviePicture.Size = new Size(276, PictureHeight -4);
            timer1.Start();
        }

        private static Image GetImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return (Image.FromStream(ms));
            }
        }

        private void MovieInfo_MouseEnter(object sender, EventArgs e)
        {
            this.Size = new Size(FormWidth + 10, FormHeight + 10);
            MoviePicture.Size = new Size(290, PictureHeight + 10);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                this.Size = new Size(FormWidth, FormHeight);
                MoviePicture.Size = new Size(280, PictureHeight);
                timer1.Stop();
                MovieDetails movieDetails = new MovieDetails();

                con.Open();
                string query = "select * from MovieTb where Name = '" + MovieName.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                movieDetails.MovieName.Text = dt.Rows[0][0].ToString();
                movieDetails.AgeRate.Text ="Age Rating: "+ dt.Rows[0][3].ToString();
                movieDetails.IMDbRate.Text = dt.Rows[0][4].ToString() + "/10";
                movieDetails.Length.Text = "Length: "+dt.Rows[0][6].ToString();
                movieDetails.ReleaseDate.Text = "Release: "+((DateTime)dt.Rows[0][7]).ToString("yyyy");
                movieDetails.Description.Text = "Description: "+dt.Rows[0][9].ToString();
                movieDetails.Genres.Text = "Genres: "+dt.Rows[0][5].ToString();
                movieDetails.MoviePicture.Image = GetImage((byte[])dt.Rows[0][1]);
                con.Close();

                movieDetails.ShowDialog();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void MoviePicture_MouseLeave(object sender, EventArgs e)
        {
            
            this.Size = new Size(FormWidth, FormHeight);
            MoviePicture.Size = new Size(280, PictureHeight);

        }

    }
}
