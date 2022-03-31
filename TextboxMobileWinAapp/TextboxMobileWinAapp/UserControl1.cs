using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextboxMobileWinAapp
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void txt_onlynum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar > 47 && e.KeyChar < 58 || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }
    }
}
