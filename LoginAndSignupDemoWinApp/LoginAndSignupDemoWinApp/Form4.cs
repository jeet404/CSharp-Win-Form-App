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
    public partial class Form4 : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
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

            da = new SqlDataAdapter("SELECT * FROM users", conn);
            dt = new DataTable();
            da.Fill(dt);
            cmb_usnm.DisplayMember = "username";
            cmb_usnm.ValueMember = "Id";
            cmb_usnm.DataSource = dt;
        }

        private void cmb_usnm_SelectedIndexChanged(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM users WHERE Id = "+cmb_usnm.SelectedValue+"", conn);
            dt = new DataTable();
            da.Fill(dt);
            lbl_pass.Text = dt.Rows[0][2].ToString();
        }
    }
}
