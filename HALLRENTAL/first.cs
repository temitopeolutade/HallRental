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
    public partial class first : Form
    {
        public first()
        {
            InitializeComponent();
        }
        private int number = 1;
        private void LoadImage()
        {
            if (number == 5)
            {
                number = 1;
            }
            firstsl.ImageLocation = string.Format(@"img\{0}.jpg", number);
            number++;
        }

       

        

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void home_Click(object sender, EventArgs e)
        {
            dashboard ot = new dashboard();
            ot.Show();
            this.Hide();
        }

        
    }
}
