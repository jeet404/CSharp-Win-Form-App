using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ConnectToOLEDBWinAPP
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

                conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\WorkSpace\BCA SEM-4\C# Form App\ConnectToOLEDBWinAPP\ConnectToOLEDBWinAPP\Database1.mdb"); 
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
            cmd = new OleDbCommand("INSERT INTO stud (s_name,s_pass) VALUES(@username,@password)", conn);
            cmd.Parameters.AddWithValue("@username", txt_unm.Text);
            cmd.Parameters.AddWithValue("@password", txt_pass.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Inserted");
        }
    }
}
