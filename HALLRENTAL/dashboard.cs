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
            
        }

        private void view_Click(object sender, EventArgs e)
        {
            halls1.BringToFront();
        }

        private void home_Click(object sender, EventArgs e)
        {

            slider1.BringToFront();
        }
    }
}
