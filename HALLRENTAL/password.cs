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
    public partial class password : Form
    {
        public password()
        {
            InitializeComponent();
            label2.Hide();
        }
        public string constringg = "Data Source=LAPTOP-3F4N0JP3\\SQLEXPRESS;Initial Catalog=hallrental;Integrated Security=True";
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            try
            {

                string query = "select password  from reg where  username ='" + username.Text.ToString() + "' and email='" + email.Text.ToString() + "'"; 
                SqlConnection network = new SqlConnection(constringg);
                SqlCommand network2 = new SqlCommand(query, network);
                network.Open();
                SqlDataAdapter myadapter = new SqlDataAdapter();
                myadapter.SelectCommand = network2;
                DataTable dd = new DataTable();
                myadapter.Fill(dd);
                dataGridView1.DataSource = dd;
                label2.Show();


            }
            catch (Exception ac)
            {
                Console.WriteLine(ac.ToString());
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 op = new Form1();
            op.Show();
            this.Hide();
        }
    }
}
