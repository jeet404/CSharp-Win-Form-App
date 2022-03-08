using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataBaseConnectionDemoWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_con_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\WorkSpace\BCA SEM-4\C# Form App\DataBaseConnectionDemoWinApp\DataBaseConnectionDemoWinApp\Database1.mdf';Integrated Security=True");
            conn.Open();
            MessageBox.Show("Connected Successfully");
        }

        private void btn_discon_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\WorkSpace\BCA SEM-4\C# Form App\DataBaseConnectionDemoWinApp\DataBaseConnectionDemoWinApp\Database1.mdf';Integrated Security=True");
            conn.Close();
            MessageBox.Show("Disconnected Successfully");
        }
    }
}
