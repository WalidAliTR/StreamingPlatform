using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StreamingPlatform
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public static int UserID;
        public static string UserPassword;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kg462\Desktop\StreamingPlatform\StreamingPlatform\Database.mdf;Integrated Security=True");

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (Login())
            {
                this.Hide();
                MainMenu menu = new MainMenu();
                menu.Show();
            }
            else { MessageBox.Show("the data is worng, Please Try Again"); UserName.Clear(); Passwordtxt.Clear(); UserName.Focus(); }
        }


        Boolean Login()
        {
            try
            {
                string query = "select * from UserTb where UserName='" + UserName.Text + "' and Password='" + Passwordtxt.Text + "'";
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0) {
                    UserID = Convert.ToInt32(dt.Rows[0][0]);
                    UserPassword = dt.Rows[0][1].ToString();
                    return true;
                }
                else return false;
            }
            catch { con.Close(); return false; }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManageProfile manageProfile = new ManageProfile();
            manageProfile.ShowDialog();
        }
    }
}
