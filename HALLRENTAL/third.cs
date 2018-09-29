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
    public partial class third : Form
    {
        public third()
        {
            InitializeComponent();
        }


        int number3 = 1;
        private void LoadImages1()
        {
            
            if (number3 == 5)
           
                
                {
                    number3 = 1;
                }
                thirdsl.ImageLocation = string.Format(@"imgss\{0}.jpg", number3);
                number3++;
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadImages1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            payment dapo = new payment();
            dapo.Show();
            this.Show();
        }

        private void home_Click(object sender, EventArgs e)
        {
            dashboard ma = new dashboard();
            ma.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            second ha = new second();
            ha.Show();
            this.Hide();
        }
    }
}
