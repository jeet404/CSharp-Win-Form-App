using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CrystelReportDemoWinApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer1.RefreshReport();
            this.crystalReportViewer1.RefreshReport();
            CrystalReport1 cr1 = new CrystalReport1();
            crystalReportViewer1.ReportSource = cr1;
        }
    }
}
