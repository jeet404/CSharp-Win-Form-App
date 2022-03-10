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
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_regi_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\WorkSpace\BCA SEM-4\C# Form App\LoginAndSignupDemoWinApp\LoginAndSignupDemoWinApp\userdb.mdf';Integrated Security=True");
            conn.Open();
            if(conn.State == ConnectionState.Open)
            {
                lbl_stat.BackColor = Color.Green;
            }
            else
            {
                lbl_stat.BackColor = Color.Red;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM users WHERE username = '"+txt_unm.Text+"' AND password = '"+txt_pass.Text+"'",conn);
            dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successfully.");
            }
            else
            {
                MessageBox.Show("Data Not Exist");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }
    }
}
