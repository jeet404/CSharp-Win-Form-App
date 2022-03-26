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

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            CrystalReport1 cr1 = new CrystalReport1();
            reportViewer1.LocalReport.ReportPath = @"C:\WorkSpace\BCA SEM-4\C# Form App\CrystelReportDemoWinApp\CrystelReportDemoWinApp\CrystalReport1.rpt";
        }
    }
}
