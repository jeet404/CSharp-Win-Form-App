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

namespace LoginAttemptWinApp
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        int attempt = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM user_data WHERE username = '"+txt_unm.Text+"' and password = '"+txt_pass.Text+"'", conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successfully");
            }
            else
            {
                attempt--;
                MessageBox.Show("Not Matched, "+attempt.ToString()+" Attempt Left!");

            }
            if (attempt == 0)
            {
                txt_unm.Enabled = false;
                txt_pass.Enabled = false;
                btn_login.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\WorkSpace\BCA SEM-4\C# Form App\LoginAttemptWinApp\LoginAttemptWinApp\users.mdf';Integrated Security=True");
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
    }
}
