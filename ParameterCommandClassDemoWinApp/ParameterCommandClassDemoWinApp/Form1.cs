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

namespace ParameterCommandClassDemoWinApp
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("INSERT INTO user_detail VALUES(@u_name,@u_pass)",conn);
            cmd.Parameters.AddWithValue("@u_name", txt_unm.Text);
            cmd.Parameters.AddWithValue("@u_pass", txt_pass.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Inserted Successfully");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename='C:\WorkSpace\BCA SEM-4\C# Form App\ParameterCommandClassDemoWinApp\ParameterCommandClassDemoWinApp\User_Data.mdf'; Integrated Security = True");
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
