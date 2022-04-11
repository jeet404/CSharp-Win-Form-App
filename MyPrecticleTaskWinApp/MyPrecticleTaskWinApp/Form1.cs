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

namespace MyPrecticleTaskWinApp
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        string str_b;
        string str_f;
        RadioButton[] arrB = new RadioButton[3];
        RadioButton[] arrF = new RadioButton[3];
        public Form1()
        {
            InitializeComponent();
            arrB[0] = rdo_b1;
            arrF[0] = rdo_f1;
            arrB[1] = rdo_b2;
            arrF[1] = rdo_f2;
            arrB[2] = rdo_b3;
            arrF[2] = rdo_f3;
        }

        //For Clear Control's value
        public void Clean()
        {
            for (int i = 0; i < arrB.Length; i++)
            {
                arrB[i].Checked = false;
                arrF[i].Checked = false;
            }
            txt_name.Clear();
            txt_city.Clear();
        }

        //For to get backcolor choice
        public void chk_b()
        {
            str_b = "";
            for (int i = 0; i < arrB.Length; i++)
            {
                if (arrB[i].Checked)
                {
                    str_b = arrB[i].Text;
                }
            }
        }

        //For to get forecolor choice
        public void chk_f()
        {
            str_f = "";
            for (int i = 0; i < arrF.Length; i++)
            {
                if (arrF[i].Checked)
                {
                    str_f = arrF[i].Text;
                }
            }
        }

        //For to Check Combination in not same of GroupBox(BackColor Side)
        public void chk_matchB()
        {
            for (int i = 0; i < arrB.Length; i++)
            {
                if (arrB[i].Text == arrF[i].Text)
                {
                    if (arrB[i].Checked && arrB[i] != arrF[i])
                    {
                        arrF[i].Checked = false;
                    }
                }
                else
                {
                    arrF[i].Checked = true;
                }
            }
        }

        //For to Check Combination in not same of GroupBox(ForeColor Side)
        public void chk_matchF()
        {
            for (int i = 0; i < arrF.Length; i++)
            {
                if (arrF[i].Text == arrB[i].Text)
                {
                    if (arrF[i].Checked && arrF[i] != arrB[i])
                    {
                        arrB[i].Checked = false;
                    }
                }
                else
                {
                    arrB[i].Checked = true;
                }
            }
        }

        //When already Combination of backcolor and forecolor exist 3 times then this function disables 'save' Button.
        public void chk_dup()
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_test WHERE d_backcolor = '"+str_b+"' AND d_forecolor = '"+str_f+"'", conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 3)
            {
                btn_save.Enabled = false;
            }
            else
            {
                btn_save.Enabled = true;
            }
        }

        //Connect to Database
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //You need to put your Connection string by replacing below
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\WorkSpace\BCA SEM-4\C# Form App\MyPrecticleTaskWinApp\MyPrecticleTaskWinApp\test_db.mdf';Integrated Security=True");
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    lbl_stat.BackColor = Color.Green;
                }
            }
            catch
            {
                lbl_stat.BackColor = Color.Red;
            }
        }

        //Insert Data into DataBase
        private void btn_save_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("INSERT INTO tbl_test VALUES('"+txt_name.Text+"','"+txt_city.Text+"','"+str_b+"','"+str_f+"')", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Inserted Successfully");
            Clean();
        }

        //Find/Search Data From DataBase
        private void btn_search_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_test WHERE id = "+txt_id.Text+"", conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txt_name.Text = dt.Rows[0][1].ToString();
                txt_city.Text = dt.Rows[0][2].ToString();
                for (int i = 0; i < arrB.Length; i++)
                {
                    if (arrB[i].Text == dt.Rows[0][3].ToString())
                    {
                        arrB[i].Checked = true;
                    }
                }
                for (int i = 0; i < arrF.Length; i++)
                {
                    if (arrF[i].Text == dt.Rows[0][4].ToString())
                    {
                        arrF[i].Checked = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Data Not Found of Id = "+txt_id.Text+"", "Data Message");
            }
        }

        //clear control values when txt_id's text is changed
        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            Clean();
        }

        private void rdo_b1_CheckedChanged(object sender, EventArgs e)
        {
            chk_matchB();
            chk_b();
            chk_dup();
        }

        private void rdo_f1_CheckedChanged(object sender, EventArgs e)
        {
            chk_matchF();
            chk_f();
            chk_dup();
        }

        private void rdo_b2_CheckedChanged(object sender, EventArgs e)
        {
            chk_matchB();
            chk_b();
            chk_dup();
        }

        private void rdo_f2_CheckedChanged(object sender, EventArgs e)
        {
            chk_matchF();
            chk_f();
            chk_dup();
        }

        private void rdo_b3_CheckedChanged(object sender, EventArgs e)
        {
            chk_matchB();
            chk_b();
            chk_dup();
        }

        private void rdo_f3_CheckedChanged(object sender, EventArgs e)
        {
            chk_matchF();
            chk_f();
            chk_dup();
        }
    }
}
