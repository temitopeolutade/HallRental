using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HALLRENTAL.user_controls
{
    public partial class slider : UserControl
    {
        public slider()
        {
            InitializeComponent();
        }
        private int number3 = 1;
        private void LoadNextImage()
        {

            if (number3 == 5)
            {
                number3 = 1;
            }
            slide.ImageLocation = string.Format(@"imgss\{0}.jpg", number3);
            number3++;

        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
    }
}
