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

namespace ComboBoxWithPictureBoxDBWinApp
{
    public partial class Form2 : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\WorkSpace\BCA SEM-4\C# Form App\ComboBoxWithPictureBoxDBWinApp\ComboBoxWithPictureBoxDBWinApp\flagdb.mdf';Integrated Security=True");
            conn.Open();

            da = new SqlDataAdapter("SELECT * FROM images", conn);
            dt = new DataTable();
            da.Fill(dt);
            cmb_country.ValueMember = "p_id";
            cmb_country.DisplayMember = "p_name";
            pictureBox1.Load(dt.Rows[0][1].ToString());
            cmb_country.DataSource = dt;
        }

        private void cmb_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM images WHERE p_id = "+cmb_country.SelectedValue+"", conn);
            dt = new DataTable();
            da.Fill(dt);
            cmb_country.DisplayMember = "p_name";
            pictureBox1.Load(dt.Rows[0][1].ToString());
        }
    }
}
