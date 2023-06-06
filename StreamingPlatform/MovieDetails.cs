using AxWMPLib;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamingPlatform
{
    public partial class MovieDetails : Form
    {
        public MovieDetails()
        {
            InitializeComponent();
        }
        SqlConnection con= new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kg462\Desktop\StreamingPlatform\StreamingPlatform\Database.mdf;Integrated Security=True");

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                mediaPlayer.VideoPlayer.URL = "";
                mediaPlayer.ShowTrailer.Show();
                this.Refresh();
                this.Hide();
            }
            catch{ }
        }

        private void AddToWatchlistBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string check = "select * from watchlist where UserID='" + LoginForm.UserID + "' and MovieName='" + MovieName.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(check, con);
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("delete from watchlist where UserID='" + LoginForm.UserID + "' and MovieName='" + MovieName.Text + "'",con);
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("The Movie Has Removed From Your Watchlist!");
            }
            else
            {
                string query = "insert into watchlist values ('" + MovieName.Text + "','" + LoginForm.UserID + "')";
                cmd = new SqlCommand(query,con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("The Movie Added To Your Watchlist Successfully!");
            }
            con.Close();
        }

        private void DeleteMovieBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure That You Want To Delete The Movie? You Can't Undo That If You Select Yes!","Confirmation Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) { 
            string query = "delete from MovieTb where Name='"+MovieName.Text+"'";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("The Movie Has Been Deleted!");
            cmd = new SqlCommand("delete from watchlist where MovieName = '"+MovieName.Text+"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            this.Close();
            }
        }

    }
}