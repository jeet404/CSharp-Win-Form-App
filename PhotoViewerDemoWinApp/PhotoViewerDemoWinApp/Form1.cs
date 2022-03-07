using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoViewerDemoWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showpic(object sender, EventArgs e)
        {
            if(rdo_ironman.Checked)
            {
                pic1.Load("C://Users/Jeet404/Downloads/ironman.jpg");
            }
            else if(rdo_cap.Checked)
            {
                pic1.Load("C://Users/Jeet404/Downloads/cap.jpg");
            }
            else if(rdo_thor.Checked)
            {
                pic1.Load("C://Users/Jeet404/Downloads/thor.jpg");
            }
            else if(rdo_doc.Checked)
            {
                pic1.Load("C://Users/Jeet404/Downloads/doc.jpg");
            }
        }
    }
}
