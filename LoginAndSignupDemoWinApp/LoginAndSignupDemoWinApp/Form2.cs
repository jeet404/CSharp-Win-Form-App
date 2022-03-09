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

namespace LoginAndSignupDemoWinApp
{
    public partial class Form2 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("INSERT INTO users VALUES('"+txt_rusnm.Text+"','"+txt_rpass.Text+"')",conn);
            cmd.ExecuteNonQuery();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\WorkSpace\BCA SEM-4\C# Form App\LoginAndSignupDemoWinApp\LoginAndSignupDemoWinApp\userdb.mdf';Integrated Security=True");
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                lbl_stat.BackColor = Color.Green;
            }
            else
            {
                lbl_stat.BackColor = Color.Red;
            }
        }
    }
}
