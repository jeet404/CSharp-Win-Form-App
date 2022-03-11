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
using System.Collections;

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
            ArrayList al = new ArrayList();
            foreach (var checkedItem in this.chkbl_hb.CheckedItems)
            {

                strhb += checkedItem.ToString()+",";
                al.Add(checkedItem.ToString());
            }
            //strhb = strhb.TrimEnd(',');
            strhb = string.Join(",", al.ToArray()); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\WorkSpace\BCA SEM-4\C# Form App\StudentRegiFormWinApp\StudentRegiFormWinApp\stud_data.mdf';Integrated Security=True");
            conn.Open();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            check_rdo();
            if (rdotmp == 0)
            {
                gen = "F";
            }
            else
            {
                gen = "M";
            }
            check_hb();
            cmd = new SqlCommand("INSERT INTO studs VALUES('"+txt_fname.Text+"','"+txt_sname.Text+"','"+gen+"','"+cmb_cast.SelectedItem+"','"+img_path+"','"+strhb+"')", conn);
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM studs WHERE s_id = "+txt_id.Text+"", conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txt_fname.Text = dt.Rows[0][1].ToString();
                txt_sname.Text = dt.Rows[0][2].ToString();
                string genres = dt.Rows[0][3].ToString();
                if (genres == "M")
                {
                    rdo_m.Checked = true;
                }
                else
                {
                    rdo_fe.Checked = true;
                }
                cmb_cast.Text = dt.Rows[0]["s_cast"].ToString();
                string[] gethb = dt.Rows[0]["s_hobby"].ToString().Split(',');
                for (int i = 0; i<chkbl_hb.Items.Count; i++)
                {
                    if (gethb.Contains(chkbl_hb.Items[i].ToString()))
                    {
                        chkbl_hb.SetItemChecked(i, true);
                    }
                }
                string p_path = dt.Rows[0][5].ToString();
                img_path = p_path;
                pic_img.Load(p_path);
            }
            else
            {
                MessageBox.Show("Data Doesn't Exist!");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            check_rdo();
            if (rdotmp == 0)
            {
                gen = "F";
            }
            else
            {
                gen = "M";
            }
            check_hb();
            cmd = new SqlCommand("UPDATE studs SET s_fname = '"+txt_fname.Text+"' ,s_sname = '"+txt_sname.Text+"' ,s_gender = '"+gen+"' ,s_cast = '"+cmb_cast.SelectedItem+"' ,s_img = '"+img_path+"' ,s_hobby = '"+strhb+"' WHERE s_id = "+txt_id.Text+"", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated Successfully");
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i<chkbl_hb.Items.Count; i++)
            {
                chkbl_hb.SetItemChecked(i, false);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("DELETE FROM studs WHERE s_id = "+txt_id.Text+"", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Successfully");
            txt_id.Text = "";
            txt_fname.Text = "";
            txt_sname.Text = "";
            rdo_m.Checked = false;
            rdo_fe.Checked = false;
            for (int i = 0; i<chkbl_hb.Items.Count; i++)
            {
                chkbl_hb.SetItemChecked(i, false);
            }
            img_path = "";
            pic_img.Image = null;
        }
    }
}