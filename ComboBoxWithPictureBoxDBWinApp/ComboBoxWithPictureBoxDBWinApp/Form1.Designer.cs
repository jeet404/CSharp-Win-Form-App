namespace ComboBoxWithPictureBoxDBWinApp
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_choose = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_country = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Country";
            // 
            // btn_choose
            // 
            this.btn_choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_choose.Location = new System.Drawing.Point(150, 46);
            this.btn_choose.Name = "btn_choose";
            this.btn_choose.Size = new System.Drawing.Size(167, 42);
            this.btn_choose.TabIndex = 3;
            this.btn_choose.Text = "Choose File";
            this.btn_choose.UseVisualStyleBackColor = true;
            this.btn_choose.Click += new System.EventHandler(this.btn_choose_Click);
            // 
            // btn_show
            // 
            this.btn_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.Location = new System.Drawing.Point(311, 376);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(167, 42);
            this.btn_show.TabIndex = 4;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(12, 376);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(167, 42);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_country
            // 
            this.txt_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_country.Location = new System.Drawing.Point(150, 14);
            this.txt_country.Name = "txt_country";
            this.txt_country.Size = new System.Drawing.Size(167, 26);
            this.txt_country.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 424);
            this.Controls.Add(this.txt_country);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_choose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_choose;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_country;
    }
}

