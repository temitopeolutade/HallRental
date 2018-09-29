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
using System.IO;

namespace HALLRENTAL
{
    public partial class profile : Form
    {
        public profile()
        {
            InitializeComponent();
        }
        public string connect = "Data Source=LAPTOP-3F4N0JP3\\SQLEXPRESS;Initial Catalog=hallrental;Integrated Security=True";

        private void save_Click(object sender, EventArgs e)
        {
            
           // SqlConnection con = new SqlConnection(connect);

            //con.Open();

           // if (con.State == System.Data.ConnectionState.Open)
           // {
                if (username.Text == "" || fullname.Text == "" || password.Text == "" || email.Text == "" || address.Text == "")
                {
                    MessageBox.Show("ensure to fill all available box", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                { 
                    using (SqlConnection cons = new SqlConnection(connect))
                    {
                        cons.Open();

                        bool exists = false;

                        // create a command to check if the username exists
                        using (SqlCommand cmd = new SqlCommand("select count(*) from reg where username = @username", cons))
                        {
                            cmd.Parameters.AddWithValue("username",username.Text);
                            exists = (int)cmd.ExecuteScalar() > 0;
                        }

                        // if exists, show a message error
                        if (exists)
                            MessageBox.Show(username, "This username has been using by another user.");
                        else
                        {
                            // does not exists, so, persist the user
                            using (SqlCommand cmd = new SqlCommand("INSERT INTO reg values (@uniqueid, @username, @fullname, @password, @email,@address)", cons))
                            {
                                cmd.Parameters.AddWithValue("uniqueid", id.Text);
                                cmd.Parameters.AddWithValue("username", username.Text);
                                cmd.Parameters.AddWithValue("fullname", fullname.Text);
                                cmd.Parameters.AddWithValue("password", password.Text);
                                cmd.Parameters.AddWithValue("email", email.Text);
                                cmd.Parameters.AddWithValue("address", address.Text);
                                

                           cmd.ExecuteNonQuery();
                            MessageBox.Show("successfully saved");
                            Form1 firstclass = new Form1();
                            firstclass.Show();
                            this.Hide();
                            }
                            
                        }

                    cons.Close();
                }


                




                /** string q = "insert into newreg values('" + username.Text.ToString() + "','" + fullname.Text.ToString() + "', '" + password.Text.ToString() + "', '" + email.Text + "', '" + address.Text.ToString() + "','" + upload_pics + "','" +id.Text + "')";
                 SqlCommand cma = new SqlCommand(q, con);
                 cma.ExecuteNonQuery();
                 MessageBox.Show("Successfully Saved ");

                 dashboard org = new dashboard();
                 org.Show();
                 this.Hide();
             }
          con.Close();**/

                string fileName = " userinfo.txt";
                try
                {
                    using (StreamWriter fileStr = File.CreateText(fileName))
                    {
                        fileStr.WriteLine(username.Text);
                        fileStr.WriteLine(fullname.Text);
                        fileStr.WriteLine(password.Text);
                        fileStr.WriteLine(email.Text);
                        fileStr.WriteLine(address.Text);
                    }
                }
                catch (Exception tope)
                {
                    Console.WriteLine(tope.ToString());
                }
            }
            savep();
        }

      

        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //nothing
             
        }



        private void savep()
        {
            SqlConnection conn = new SqlConnection(connect);
            
          

            if (upload_pics.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                upload_pics.Image.Save(ms, upload_pics.Image.RawFormat);
                byte[] a = ms.GetBuffer();
                ms.Close();
                string c = "insert into newreg(image) values ('"+ upload_pics+ "')";
                SqlCommand cda = new SqlCommand(c, conn);
                cda.Parameters.AddWithValue("@picture", a);
                conn.Open();
                cda.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("upload successful");
                
               

            }
        }

        private void upload_Click(object sender, EventArgs e)
        {

            string imagelocation;
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg) |*.jpg| PNG files(*.png)  |*.png| All files (*.*)|*.*  ";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagelocation = dialog.FileName;
                    upload_pics.ImageLocation = imagelocation;
                }
            }catch(Exception ar)
            {
                MessageBox.Show("An error occured ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }
        
        SqlConnection connn = new SqlConnection("Data Source=LAPTOP-3F4N0JP3\\SQLEXPRESS;Initial Catalog=hallrental;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
