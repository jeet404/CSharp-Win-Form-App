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

namespace StudentRegiFormWinApp
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        int rdotmp;
        string gen;
        string strhb;
        string img_path;
        public Form1()
        {
            InitializeComponent();
        }

        private void check_rdo()
        {
            rdotmp = 0;
            if (rdo_m.Checked)
            {
                rdotmp = 1;
            }
        }

        private void check_hb()
        {
            strhb = "";
            foreach (var checkedItem in this.chkbl_hb.CheckedItems)
            {

                strhb += checkedItem.ToString()+",";

            }
            strhb = strhb.TrimEnd(',');
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\WorkSpace\BCA SEM-4\C# Form App\StudentRegiFormWinApp\StudentRegiFormWinApp\stud_data.mdf';Integrated Security=True");
            conn.Open();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            check_rdo();
            if(rdotmp == 0)
            {
                gen = "F";
            }
            else
            {
                gen = "M";
            }
            check_hb();
            cmd = new SqlCommand("INSERT INTO studs VALUES('"+txt_fname.Text+"','"+txt_sname.Text+"','"+gen+"','"+cmb_cast.SelectedItem+"','"+img_path+"','"+strhb+"')",conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Inserted Successfully");
        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            img_path = ofd.FileName;
            pic_img.Load(img_path);
        }
    }
}
