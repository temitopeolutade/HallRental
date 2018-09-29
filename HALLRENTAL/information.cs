using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace HALLRENTAL
{
    public partial class information : Form
    {
        public information()
        {
            InitializeComponent();

        }
        public string source= "Data Source=LAPTOP-3F4N0JP3\\SQLEXPRESS;Initial Catalog=hallrental;Integrated Security=True";

        private void information_Load(object sender, EventArgs e)
        {
          
            
            
            /**string[] content = new string[5];
            int i = 0;
            string filename = "userinfo.txt";
            try
            {
                string a = "";
                using (StreamReader sa = File.OpenText(filename))
                {
                    while ((a = sa.ReadLine()) != null)
                    {
                        content[i] = a;
                        i++;
                    }
                }
                username.Text = content[0] ;
                fullname.Text = content[1];
                password.Text = content[2];
                email.Text = content[3];
                address.Text = content[4];
                
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.ToString());
            }**/
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(source);
            con.Open();
            string query = " select * from reg where uniqueid = " + id.Text;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                username.Text = (dr["username"].ToString());
                fullname.Text = (dr["fullname"].ToString());
                email.Text = (dr["email"].ToString());
                address.Text = (dr["address"].ToString());

            }

            else
            {
                MessageBox.Show("You entered the wrong id ");
            }


        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=LAPTOP-3F4N0JP3\\SQLEXPRESS;Initial Catalog=hallrental;Integrated Security=True";
            string query = "update  reg set uniqueid='" + this.id.Text.ToString() + "', username = '" + this.username.Text.ToString() + "',fullname ='" + this.fullname.Text.ToString() + "', email='" + this.email.Text.ToString() + "', address='" + this.address.Text.ToString() + "','";
            string query2 = "update reg set uniqueid='" + this.id.Text + "',username='" + this.username.Text + "',fullname='" + this.fullname.Text + "',email='" + email.Text + "',address='" + this.address.Text + "'where uniqueid='" + this.id.Text + "' ; ";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand data = new SqlCommand(query2, con);
            SqlDataReader myred;

            try
            {
                con.Open();

                myred = data.ExecuteReader();
                MessageBox.Show("Successfully Updated");
                while (myred.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dashboard igh = new dashboard();
            igh.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
