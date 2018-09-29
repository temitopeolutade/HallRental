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
    public partial class second : Form
    {
        public second()
        {
            InitializeComponent();
        }

        private int number2 = 1;
        private void LoadImages()
        {
            if (number2 == 5)
            {
                number2 = 1;
            }
            secondsl.ImageLocation = string.Format(@"imgs\{0}.jpg", number2);
            number2++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadImages();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            payment tope = new payment();
            tope.Show();
            this.Hide();

        }

        private void home_Click(object sender, EventArgs e)
        {
            dashboard ra = new dashboard();
            ra.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            third n = new third();
            n.Show();
            this.Hide();
        }
    }
}
