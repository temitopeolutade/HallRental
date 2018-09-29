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
    public partial class deleteuser : Form
    {
        public deleteuser()
        {
            InitializeComponent();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=LAPTOP-3F4N0JP3\\SQLEXPRESS;Initial Catalog=hallrental;Integrated Security=True";
            string query = "delete from reg where @username= @username2";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand data = new SqlCommand(query, con);
            SqlDataReader myred;

            try
            {
                con.Open();
                data.Parameters.AddWithValue("username", username2.Text);
                myred = data.ExecuteReader();
                MessageBox.Show("Successfully Deleted");
                while (myred.Read())
                {

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin cs = new admin();
            cs.Show();
            this.Hide();
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fg = new Form1();
            fg.Show();
            this.Hide();
        }
    }
}
