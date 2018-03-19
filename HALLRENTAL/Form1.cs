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

namespace HALLRENTAL
{
    public partial class Form1 : Form
    {
        static int attempt = 3;
        public Form1()
        {
            InitializeComponent();
        }
        public string constring = "Data Source=LAPTOP-3F4N0JP3\\SQLEXPRESS;Initial Catalog=hallrental;Integrated Security=True";
        

        private void login_Click(object sender, EventArgs e)
        {
            if (attempt == 0)
            {
               lbl_Msg.Text="ALL 3 ATTEMPTS HAVE FAILED - CONTACT ADMIN";
                return;
            }
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlDataAdapter mm = new SqlDataAdapter("select count (*) from signup where username ='" + username.Text.ToString() + "' and password='" + password.Text.ToString() + "'", con);
            DataTable dt = new DataTable();
            mm.Fill(dt);
           
            //else
           // {
             //   MessageBox.Show("please enter correct username and password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
          //  }



            if (dt.Rows[0][0].ToString() == "1")
            {
                logo.Image = new Bitmap(@"C: \Users\TEMITOPE OLUTADE PC\Documents\Visual Studio 2017\Projects\HALLRENTAL\granted.jpg");
                MessageBox.Show("YOU ARE GRANTED WITH ACCESS");
                dashboard orp = new dashboard();
                orp.Show();
                this.Hide();
            }

            else
            {

                logo.Image = new Bitmap(@"C: \Users\TEMITOPE OLUTADE PC\Documents\Visual Studio 2017\Projects\HALLRENTAL\denied2.jpg");
                MessageBox.Show("YOU ARE NOT GRANTED WITH ACCESS");
                lbl_Msg.Text = ("You Have Only " + Convert.ToString(attempt) + " Attempt Left To Try");
                --attempt;
                this.username.Text = " ";
                this.password.Text = " ";
            }
            con.Close();


        }

        private void signup_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into signup(username,password)values('" + username.Text.ToString() + "','" + password.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                dashboard org = new dashboard();
                org.Show();
                this.Hide();

            }
        }
    }
}
