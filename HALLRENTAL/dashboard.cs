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
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();



        }

        private void view_Click(object sender, EventArgs e)
        {
            halls1.BringToFront();
            btn1.Show();
            btn2.Show();
            btn3.Show();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();




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
           
        }
    }
}
