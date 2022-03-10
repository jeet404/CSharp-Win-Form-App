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
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\WorkSpace\BCA SEM-4\C# Form App\ComboBoxWithPictureBoxDBWinApp\ComboBoxWithPictureBoxDBWinApp\flagdb.mdf';Integrated Security=True");
            conn.Open();
        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:";
            ofd.ShowDialog();
            pictureBox1.Load(ofd.FileName);
            path = ofd.FileName.ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_country.Text == "" && path == "")
            {
                MessageBox.Show("Plz Fill Proper Data!");
            }
            else
            {
                cmd = new SqlCommand("INSERT INTO images VALUES('"+path+"','"+txt_country.Text+"')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Picture Uploaded");
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
