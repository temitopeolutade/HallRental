﻿using System;
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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        public string constringg = "Data Source=LAPTOP-3F4N0JP3\\SQLEXPRESS;Initial Catalog=hallrental;Integrated Security=True";

        private void view_Click(object sender, EventArgs e)
        {

            try
            {

                string query = "select id,username,fullname,password,email,address from reg ";
                SqlConnection network = new SqlConnection(constringg);
                SqlCommand network2 = new SqlCommand(query, network);
                network.Open();
                SqlDataAdapter myadapter = new SqlDataAdapter();
                myadapter.SelectCommand = network2;
                DataTable dd = new DataTable();
                myadapter.Fill(dd);
                dataGridView1.DataSource = dd;
               


            }
            catch (Exception ac)
            {
                Console.WriteLine(ac.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleteuser del = new deleteuser();
            del.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 v = new Form1();
            v.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
