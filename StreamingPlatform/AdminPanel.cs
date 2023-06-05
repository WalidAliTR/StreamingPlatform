using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.LinkLabel;
using System.Web.UI.WebControls;

namespace StreamingPlatform
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        string videoPath, imgloc;
        long fileSizeInBytes;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kg462\Desktop\StreamingPlatform\StreamingPlatform\Database.mdf;Integrated Security=True");
        SqlCommand cmd;

        private void VideoBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Video Files|*.avi;*.mp4;*.mov;*.mkv;*.flv;*.wmv|All Files|*.*";
                openFileDialog.Title = "Select a Video File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (Stream fileStream = openFileDialog.OpenFile())
                    {
                        fileSizeInBytes = fileStream.Length;
                        VideoName.Text = videoPath = ((FileStream)fileStream).Name;
                    }
                }
            }
        }

        private void CreateVideoFile()
        {
            con.Open();
            string query = "select VideoFile from MovieTb where ID=1";
            SqlCommand cmd = new SqlCommand(query, con);
            var bytes = (byte[])cmd.ExecuteScalar();
            File.WriteAllBytes(@"C:\Users\kg462\Desktop\Venom 2 Trailer.mp4", bytes);
            con.Close();
            MessageBox.Show("Video Created Successfully!!");
        }

        void ResetPage()
        {
            MovieName.Clear(); Description.Clear(); Length.Clear(); IMDbRate.Value = 0; imgloc = "";videoPath = "";VideoName.Text = "-"; PictureName.Text = "-";
            for (int i = 0; i < GenresList.Items.Count; i++) GenresList.SetItemChecked(i, false);
        }

        private void AddMoviesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string genres = "",query=""; byte[] images = null;

                if (imgloc == "") { MessageBox.Show("Please Upload The Movie Picture"); }
                else
                {
                    FileStream stream = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    images = brs.ReadBytes((int)stream.Length);
                }

                if (MovieName.Text.Length == 0 || MovieName.Text.Contains("  ") || MovieName.Text[0].ToString() == " ") { MessageBox.Show("Please Write A Correct Movie Name!!"); MovieName.Clear(); MovieName.Focus(); }
                else if (AgeRate.Text == "") { MessageBox.Show("Please Write A Correct Age Rate!!"); AgeRate.Focus(); }
                else if (Length.Text.Length == 0 || Length.Text.Contains("  ") || Length.Text[0].ToString() == " ") { MessageBox.Show("Please Write A Correct Movie Length!!"); Length.Clear(); Length.Focus(); }
                else if (GenresList.CheckedItems.Count == 0) { MessageBox.Show("Please Add At Least One Genre For The Movie!!"); }
                else
                {
                    for (int i = 0; i < GenresList.CheckedItems.Count; i++)
                    {
                        genres += GenresList.CheckedItems[i].ToString();
                        if (i + 1 != GenresList.CheckedItems.Count) genres += ",";
                    }

                    con.Open();
                    if (VideoName.Text == "-")
                    {
                        query = "insert into MovieTb (Name,Picture,AgeRating,IMDbRating,Genres,Length,Release,ShowType,Description) values (@name,@pic,@age,@rate,@genres,@length,@date,@type,@desc)";
                         cmd = new SqlCommand(query, con);
                    }
                    else {
                        query = "insert into MovieTb values (@name,@pic,@stream,@age,@rate,@genres,@length,@date,@type,@desc)";
                        cmd = new SqlCommand(query, con);
                        byte[] buffer = new byte[fileSizeInBytes];
                        using (Stream video = File.OpenRead(videoPath))
                        {
                            video.Read(buffer, 0, buffer.Length);
                        }
                        cmd.Parameters.Add("@stream", System.Data.SqlDbType.VarBinary).Value = buffer;
                    }
                    cmd.Parameters.Add(new SqlParameter("@name", MovieName.Text));
                    cmd.Parameters.Add(new SqlParameter("@pic", images));
                    cmd.Parameters.Add(new SqlParameter("@desc", Description.Text));
                    cmd.Parameters.Add(new SqlParameter("@genres", genres));
                    cmd.Parameters.Add(new SqlParameter("@rate", IMDbRate.Value));
                    cmd.Parameters.Add(new SqlParameter("@length", Length.Text));
                    cmd.Parameters.Add(new SqlParameter("@age", AgeRate.Text));
                    cmd.Parameters.Add(new SqlParameter("@type", ShowType.Text));
                    cmd.Parameters.Add(new SqlParameter("@date", ReleaseDate.Value));
                    cmd.ExecuteNonQuery(); ResetPage(); con.Close();
                    MessageBox.Show("Successful!!","Movie Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { con.Close(); }
        }

        byte[] ReadPicture() {
            FileStream stream = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
             return brs.ReadBytes((int)stream.Length);
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string genres = "", query = "";

                if (MovieName.Text.Length == 0 || MovieName.Text.Contains("  ") || MovieName.Text[0].ToString() == " ") { MessageBox.Show("Please Write A Correct Movie Name!!"); MovieName.Clear(); MovieName.Focus(); }
                else if (AgeRate.Text == "") { MessageBox.Show("Please Write A Correct Age Rate!!"); AgeRate.Focus(); }
                else if (Length.Text.Length == 0 || Length.Text.Contains("  ") || Length.Text[0].ToString() == " ") { MessageBox.Show("Please Write A Correct Movie Length!!"); Length.Clear(); Length.Focus(); }
                else if (GenresList.CheckedItems.Count == 0) { MessageBox.Show("Please Add At Least One Genre For The Movie!!"); }
                else
                {
                    for (int i = 0; i < GenresList.CheckedItems.Count; i++)
                    {
                        genres += GenresList.CheckedItems[i].ToString();
                        if (i + 1 != GenresList.CheckedItems.Count) genres += ",";
                    }

                    con.Open();
                    if (VideoName.Text == "-")
                    {
                        if (PictureName.Text == "-")
                        {
                            query = "update MovieTb set Name=@name,AgeRating=@age,IMDbRating=@rate,Genres=@genres,Length=@length,Release=@date,ShowType=@type,Description=@desc where Name = '" + SearchResults.Text + "'";
                            cmd = new SqlCommand(query, con);
                        }
                        else
                        {
                            query = "update MovieTb set Name=@name,Picture=@pic,AgeRating=@age,IMDbRating=@rate,Genres=@genres,Length=@length,Release=@date,ShowType=@type,Description=@desc where Name = '" + SearchResults.Text + "'";
                            cmd = new SqlCommand(query, con);
                            cmd.Parameters.Add(new SqlParameter("@pic", ReadPicture()));
                        }
                    }
                    else
                    {
                        if (PictureName.Text != "-")
                        {
                            query = "update MovieTb set Name=@name,Picture=@pic,VideoFile=@stream,AgeRating=@age,IMDbRating=@rate,Genres=@genres,Length=@length,Release=@date,ShowType=@type,Description=@desc where Name = '" + SearchResults.Text + "'";
                            cmd = new SqlCommand(query, con);
                            cmd.Parameters.Add(new SqlParameter("@pic", ReadPicture()));
                        }
                        else {
                            query = "update MovieTb set Name=@name,VideoFile=@stream,AgeRating=@age,IMDbRating=@rate,Genres=@genres,Length=@length,Release=@date,ShowType=@type,Description=@desc where Name = '" + SearchResults.Text + "'";
                            cmd = new SqlCommand(query, con);
                        }
                        byte[] buffer = new byte[fileSizeInBytes];
                        using (Stream video = File.OpenRead(videoPath))
                        {
                            video.Read(buffer, 0, buffer.Length);
                        }
                        cmd.Parameters.Add("@stream", SqlDbType.VarBinary).Value = buffer;
                    }
                    cmd.Parameters.Add(new SqlParameter("@name", MovieName.Text));
                    cmd.Parameters.Add(new SqlParameter("@desc", Description.Text));
                    cmd.Parameters.Add(new SqlParameter("@genres", genres));
                    cmd.Parameters.Add(new SqlParameter("@rate", IMDbRate.Value));
                    cmd.Parameters.Add(new SqlParameter("@length", Length.Text));
                    cmd.Parameters.Add(new SqlParameter("@age", AgeRate.Text));
                    cmd.Parameters.Add(new SqlParameter("@type", ShowType.Text));
                    cmd.Parameters.Add(new SqlParameter("@date", ReleaseDate.Value));
                    cmd.ExecuteNonQuery(); ResetPage(); con.Close();
                    MessageBox.Show("Successful!!", "Movie Data Edited Successfully!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message,"ERROR!!",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            finally { con.Close(); }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "select Name from MovieTb where Name like '%"+SearchBox.Text+"%'";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SearchResults.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++) {
                SearchResults.Items.Add(dt.Rows[i][0].ToString());
            }
            SearchResults.DroppedDown=true;
            con.Close();
        }

        private void SearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from MovieTb where Name = '" + SearchResults.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MovieName.Text = dt.Rows[0][0].ToString();
            AgeRate.Text = dt.Rows[0][3].ToString();
            IMDbRate.Value = Convert.ToInt32(dt.Rows[0][4]);
            Length.Text = dt.Rows[0][6].ToString();
            ReleaseDate.Value = (DateTime)dt.Rows[0][7];
            ShowType.Text= dt.Rows[0][8].ToString();
            Description.Text = dt.Rows[0][9].ToString();
            string genres="";
            foreach (char c in dt.Rows[0][5].ToString())
            {
                if (Char.IsPunctuation(c))
                {
                    GenresList.SetItemChecked(GenresList.Items.IndexOf(genres), true);
                    genres = "";
                }
                else genres += c;
            }
            GenresList.SetItemChecked(GenresList.Items.IndexOf(genres), true);
            con.Close();
        }

        private void PictureBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|All Files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgloc = dialog.FileName.ToString();
                PictureName.Text = imgloc;
            }
        }
    }
}
