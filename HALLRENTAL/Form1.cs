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
            SqlDataAdapter mm = new SqlDataAdapter("select count (*) from reg where username ='" + username.Text.ToString() + "' and password='" + password.Text.ToString() + "'", con);
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
            {
               // dashboard ad = new dashboard();
                //ad.Show();
                 profile gh = new profile();
                 gh.Show();
                 this.Hide();
            }

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void passw_Click(object sender, EventArgs e)

        {
            password add = new password();
            add.Show();
            this.Hide();
        }

        private void admin_Click(object sender, EventArgs e)
        {
            string connection = "Data Source=LAPTOP-3F4N0JP3\\SQLEXPRESS;Initial Catalog=hallrental;Integrated Security=True";
            SqlConnection cons = new SqlConnection(connection);
            cons.Open();
            SqlDataAdapter mm = new SqlDataAdapter("select count (*) from admin where username ='" + username.Text.ToString() + "' and password='" + password.Text.ToString() + "'", cons);
            DataTable dts = new DataTable();
            mm.Fill(dts);


            if (dts.Rows[0][0].ToString() == "1")
            {
                logo.Image = new Bitmap(@"C: \Users\TEMITOPE OLUTADE PC\Documents\Visual Studio 2017\Projects\HALLRENTAL\granted.jpg");
                MessageBox.Show("Welcome Admin");
                admin boss = new admin();
                boss.Show();
                this.Hide();

            }

            else
            {

                logo.Image = new Bitmap(@"C: \Users\TEMITOPE OLUTADE PC\Documents\Visual Studio 2017\Projects\HALLRENTAL\denied2.jpg");
                MessageBox.Show("YOU ARE A SCAM ");
                
                this.username.Text = " ";
                this.password.Text = " ";
            }
            cons.Close();

            
        }

        private void passw_Click_1(object sender, EventArgs e)
        {
            password af = new password();
            af.Show();
            this.Hide();
        }
    }
}
