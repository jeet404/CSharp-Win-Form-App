using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CrystelReportDemoWinApp
{
    public partial class Form1 : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\WorkSpace\BCA SEM-4\C# Form App\CrystelReportDemoWinApp\CrystelReportDemoWinApp\Database1.mdb'");
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    lbl_stat.BackColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                lbl_stat.BackColor = Color.Red;
            }
        }

        private void btn_regi_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("INSERT INTO stud (s_name,s_pass) VALUES('"+ txt_unm.Text +"','"+ txt_pass.Text +"')",conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Inserted");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
