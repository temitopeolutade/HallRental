using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HALLRENTAL
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
            slider1.BringToFront();
            btn1.Hide();
            btn2.Hide();
            btn3.Hide();
           


        }

        private void view_Click(object sender, EventArgs e)
        {
            halls1.BringToFront();
            btn1.Show();
            btn2.Show();
            btn3.Show();
            




        }

        private void home_Click(object sender, EventArgs e)
        {

            slider1.BringToFront();
            btn1.Hide();
            btn2.Hide();
            btn3.Hide();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //mistake
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            first org = new first();
            org.Show();
            this.Hide();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            second ord = new second();
            ord.Show();
            this.Hide();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            third orn = new third();
            orn.Show();
            this.Hide();
        }

        private void profilep_Click(object sender, EventArgs e)
        {

            information a = new information();
            a.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //logout
            Form1 ade = new Form1();
            ade.Show();
            this.Hide();
        }
    }
}
