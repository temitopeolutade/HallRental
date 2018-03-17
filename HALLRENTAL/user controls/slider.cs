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
        private int imageNumber = 1;
        private void LoadNextImage()
        {
            if (imageNumber == 5)
            {
                slide.ImageLocation = "C:\\Users\\TEMITOPE OLUTADE PC\\Documents\\Visual Studio 2017\\Projects\\HALLRENTAL\\HALLRENTAL\\image1" + imageNumber + ".jpg";
                imageNumber = 1;
            }
            else
            {
                slide.ImageLocation = "C:\\Users\\TEMITOPE OLUTADE PC\\Documents\\Visual Studio 2017\\Projects\\HALLRENTAL\\HALLRENTAL\\image1" + imageNumber + ".jpg";
                imageNumber += 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
    }
}
