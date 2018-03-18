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
    }
}
