namespace MyPrecticleTaskWinApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_stat = new System.Windows.Forms.Label();
            this.gb_b = new System.Windows.Forms.GroupBox();
            this.rdo_b3 = new System.Windows.Forms.RadioButton();
            this.rdo_b2 = new System.Windows.Forms.RadioButton();
            this.rdo_b1 = new System.Windows.Forms.RadioButton();
            this.gb_f = new System.Windows.Forms.GroupBox();
            this.rdo_f3 = new System.Windows.Forms.RadioButton();
            this.rdo_f2 = new System.Windows.Forms.RadioButton();
            this.rdo_f1 = new System.Windows.Forms.RadioButton();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gb_b.SuspendLayout();
            this.gb_f.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(142, 321);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(101, 36);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(249, 74);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(123, 26);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Find";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "City";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_stat
            // 
            this.lbl_stat.AutoSize = true;
            this.lbl_stat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stat.Location = new System.Drawing.Point(44, 377);
            this.lbl_stat.Name = "lbl_stat";
            this.lbl_stat.Size = new System.Drawing.Size(294, 20);
            this.lbl_stat.TabIndex = 4;
            this.lbl_stat.Text = "                                                         ";
            // 
            // gb_b
            // 
            this.gb_b.Controls.Add(this.rdo_b3);
            this.gb_b.Controls.Add(this.rdo_b2);
            this.gb_b.Controls.Add(this.rdo_b1);
            this.gb_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_b.Location = new System.Drawing.Point(12, 178);
            this.gb_b.Name = "gb_b";
            this.gb_b.Size = new System.Drawing.Size(177, 115);
            this.gb_b.TabIndex = 5;
            this.gb_b.TabStop = false;
            this.gb_b.Text = "BackColor";
            // 
            // rdo_b3
            // 
            this.rdo_b3.AutoSize = true;
            this.rdo_b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_b3.Location = new System.Drawing.Point(6, 85);
            this.rdo_b3.Name = "rdo_b3";
            this.rdo_b3.Size = new System.Drawing.Size(63, 24);
            this.rdo_b3.TabIndex = 2;
            this.rdo_b3.Text = "Blue";
            this.rdo_b3.UseVisualStyleBackColor = true;
            this.rdo_b3.CheckedChanged += new System.EventHandler(this.rdo_b3_CheckedChanged);
            // 
            // rdo_b2
            // 
            this.rdo_b2.AutoSize = true;
            this.rdo_b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_b2.Location = new System.Drawing.Point(6, 55);
            this.rdo_b2.Name = "rdo_b2";
            this.rdo_b2.Size = new System.Drawing.Size(79, 24);
            this.rdo_b2.TabIndex = 1;
            this.rdo_b2.Text = "Yellow";
            this.rdo_b2.UseVisualStyleBackColor = true;
            this.rdo_b2.CheckedChanged += new System.EventHandler(this.rdo_b2_CheckedChanged);
            // 
            // rdo_b1
            // 
            this.rdo_b1.AutoSize = true;
            this.rdo_b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_b1.Location = new System.Drawing.Point(6, 25);
            this.rdo_b1.Name = "rdo_b1";
            this.rdo_b1.Size = new System.Drawing.Size(60, 24);
            this.rdo_b1.TabIndex = 0;
            this.rdo_b1.Text = "Red";
            this.rdo_b1.UseVisualStyleBackColor = true;
            this.rdo_b1.CheckedChanged += new System.EventHandler(this.rdo_b1_CheckedChanged);
            // 
            // gb_f
            // 
            this.gb_f.Controls.Add(this.rdo_f3);
            this.gb_f.Controls.Add(this.rdo_f2);
            this.gb_f.Controls.Add(this.rdo_f1);
            this.gb_f.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_f.Location = new System.Drawing.Point(195, 178);
            this.gb_f.Name = "gb_f";
            this.gb_f.Size = new System.Drawing.Size(177, 115);
            this.gb_f.TabIndex = 0;
            this.gb_f.TabStop = false;
            this.gb_f.Text = "ForeColor";
            // 
            // rdo_f3
            // 
            this.rdo_f3.AutoSize = true;
            this.rdo_f3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_f3.Location = new System.Drawing.Point(6, 85);
            this.rdo_f3.Name = "rdo_f3";
            this.rdo_f3.Size = new System.Drawing.Size(63, 24);
            this.rdo_f3.TabIndex = 2;
            this.rdo_f3.Text = "Blue";
            this.rdo_f3.UseVisualStyleBackColor = true;
            this.rdo_f3.CheckedChanged += new System.EventHandler(this.rdo_f3_CheckedChanged);
            // 
            // rdo_f2
            // 
            this.rdo_f2.AutoSize = true;
            this.rdo_f2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_f2.Location = new System.Drawing.Point(6, 55);
            this.rdo_f2.Name = "rdo_f2";
            this.rdo_f2.Size = new System.Drawing.Size(79, 24);
            this.rdo_f2.TabIndex = 1;
            this.rdo_f2.Text = "Yellow";
            this.rdo_f2.UseVisualStyleBackColor = true;
            this.rdo_f2.CheckedChanged += new System.EventHandler(this.rdo_f2_CheckedChanged);
            // 
            // rdo_f1
            // 
            this.rdo_f1.AutoSize = true;
            this.rdo_f1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_f1.Location = new System.Drawing.Point(6, 25);
            this.rdo_f1.Name = "rdo_f1";
            this.rdo_f1.Size = new System.Drawing.Size(60, 24);
            this.rdo_f1.TabIndex = 0;
            this.rdo_f1.Text = "Red";
            this.rdo_f1.UseVisualStyleBackColor = true;
            this.rdo_f1.CheckedChanged += new System.EventHandler(this.rdo_f1_CheckedChanged);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(89, 106);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(154, 26);
            this.txt_name.TabIndex = 0;
            // 
            // txt_city
            // 
            this.txt_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_city.Location = new System.Drawing.Point(89, 138);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(154, 26);
            this.txt_city.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Orange;
            this.label3.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "Registration Form";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(89, 74);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(154, 26);
            this.txt_id.TabIndex = 7;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Id";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(384, 406);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gb_f);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.gb_b);
            this.Controls.Add(this.lbl_stat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_save);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_b.ResumeLayout(false);
            this.gb_b.PerformLayout();
            this.gb_f.ResumeLayout(false);
            this.gb_f.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_stat;
        private System.Windows.Forms.GroupBox gb_b;
        private System.Windows.Forms.RadioButton rdo_b3;
        private System.Windows.Forms.RadioButton rdo_b2;
        private System.Windows.Forms.RadioButton rdo_b1;
        private System.Windows.Forms.GroupBox gb_f;
        private System.Windows.Forms.RadioButton rdo_f3;
        private System.Windows.Forms.RadioButton rdo_f2;
        private System.Windows.Forms.RadioButton rdo_f1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label4;
    }
}

