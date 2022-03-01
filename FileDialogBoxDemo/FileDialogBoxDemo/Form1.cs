﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileDialogBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.InitialDirectory = "D:";
            ofd.Filter = "Text Files | *.txt;*.docx";
            ofd.Multiselect = true;
            ofd.ShowDialog();
            foreach (string file in ofd.FileNames)
            {
                lst_filenm.Items.Add(file);
            }
        }
    }
}
