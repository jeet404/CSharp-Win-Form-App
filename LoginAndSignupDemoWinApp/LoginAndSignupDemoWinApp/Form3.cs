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
    public partial class Form3 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM users WHERE Id ="+ txt_uid.Text +"",conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txt_unm.Text = dt.Rows[0][1].ToString();
                txt_pass.Text = dt.Rows[0][2].ToString();
            }
            else
            {
                MessageBox.Show("Id = "+txt_uid.Text+" doesn't exist!");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("UPDATE users SET username = '"+txt_unm.Text+"',password = '"+txt_pass.Text+"' WHERE Id = "+txt_uid.Text+"",conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Updated Successfully");
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("DELETE FROM users WHERE Id = "+txt_uid.Text+"",conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Deleted Successfully");
            txt_uid.Text = "";
            txt_unm.Text = "";
            txt_pass.Text = "";
        }
    }
}
