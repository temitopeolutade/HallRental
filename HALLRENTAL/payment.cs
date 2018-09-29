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
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }
        public string connectme = "Data Source=LAPTOP-3F4N0JP3\\SQLEXPRESS;Initial Catalog=hallrental;Integrated Security=True";
        private void payment_Load(object sender, EventArgs e)
        {
            //nothing
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection co = new SqlConnection(connectme);
            co.Open();

            if (type.Text == "" || name.Text=="" || number.Text== "" || ccv.Text== "")
            {
                MessageBox.Show("Sorry fill in all the boses", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else  if (co.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into payment(username,type,name,number,ccv)values('" + username.Text.ToString() + "','" + type.Text.ToString() + "','" + name.Text.ToString() + "','" + number.Text.ToString() + "','" + ccv.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(q, co);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Transaction Successful , please check your email");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dashboard nh = new dashboard();
            nh.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
