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

namespace StreamingPlatform
{
    public partial class ManageProfile : Form
    {
        public ManageProfile()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kg462\Desktop\StreamingPlatform\StreamingPlatform\Database.mdf;Integrated Security=True");

        private void CreateAccBtn_Click(object sender, EventArgs e)
        {
            try {
                if (UserName.Text.Contains(" ")) { MessageBox.Show("You Can't make any Spaces On Your User Name, Please Try Again!!"); UserName.Clear(); UserName.Focus(); }
                else if (!Email.Text.Contains("@")|| Email.Text.Length<8) { MessageBox.Show("Invaild Email, Please Try Again"); Email.Clear(); Email.Focus(); }
                else if (Passwordtxt.Text.Length < 8) { MessageBox.Show("Your Password Can't be less than 8 Characters"); Passwordtxt.Clear(); Passwordtxt.Focus(); }
                else
                {
                    con.Open();
                    string query = "insert into UserTb values ('" + UserName.Text + "','" + AccountType.Text + "','" + Email.Text + "','" + Passwordtxt.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully!");
                    con.Close();
                    this.Close();
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
