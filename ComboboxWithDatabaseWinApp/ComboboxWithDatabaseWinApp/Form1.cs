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

namespace ComboboxWithDatabaseWinApp
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

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\WorkSpace\CSharp-Win-Form-App\ComboboxWithDatabaseWinApp\ComboboxWithDatabaseWinApp\world.mdf;Integrated Security=True");
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    lbl_stat.BackColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                lbl_stat.BackColor = Color.Red;
                MessageBox.Show(ex.Message);
            }
            da = new SqlDataAdapter("SELECT * FROM country",conn);
            dt = new DataTable();
            da.Fill(dt);
            cmb_cont.DisplayMember = "c_name";
            cmb_cont.ValueMember = "c_id";
            cmb_cont.DataSource = dt;
        }

        private void cmb_cont_SelectedIndexChanged(object sender, EventArgs e)
        {

            da = new SqlDataAdapter("SELECT * FROM state WHERE c_id = "+cmb_cont.SelectedValue+"", conn);
            dt = new DataTable();
            da.Fill(dt);
            cmb_state.ValueMember = "s_id";
            cmb_state.DisplayMember = "s_name";
            cmb_state.DataSource = dt;
        }

        private void cmb_state_SelectedIndexChanged(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM city WHERE s_id = "+cmb_state.SelectedValue+"", conn);
            dt=new DataTable();
            da.Fill(dt);
            cmb_city.DisplayMember = "ct_name";
            cmb_city.ValueMember = "ct_id";
            cmb_city.DataSource = dt;
        }
    }
}
