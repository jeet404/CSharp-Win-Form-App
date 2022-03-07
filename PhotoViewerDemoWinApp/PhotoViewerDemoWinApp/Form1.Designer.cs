namespace PhotoViewerDemoWinApp
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
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.rdo_ironman = new System.Windows.Forms.RadioButton();
            this.rdo_cap = new System.Windows.Forms.RadioButton();
            this.rdo_thor = new System.Windows.Forms.RadioButton();
            this.rdo_doc = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(12, 12);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(882, 529);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // rdo_ironman
            // 
            this.rdo_ironman.AutoSize = true;
            this.rdo_ironman.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_ironman.Location = new System.Drawing.Point(8, 547);
            this.rdo_ironman.Name = "rdo_ironman";
            this.rdo_ironman.Size = new System.Drawing.Size(105, 24);
            this.rdo_ironman.TabIndex = 1;
            this.rdo_ironman.Text = "Iron Man";
            this.rdo_ironman.UseVisualStyleBackColor = true;
            this.rdo_ironman.CheckedChanged += new System.EventHandler(this.showpic);
            // 
            // rdo_cap
            // 
            this.rdo_cap.AutoSize = true;
            this.rdo_cap.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_cap.Location = new System.Drawing.Point(119, 547);
            this.rdo_cap.Name = "rdo_cap";
            this.rdo_cap.Size = new System.Drawing.Size(172, 24);
            this.rdo_cap.TabIndex = 2;
            this.rdo_cap.Text = "Captain America";
            this.rdo_cap.UseVisualStyleBackColor = true;
            this.rdo_cap.CheckedChanged += new System.EventHandler(this.showpic);
            // 
            // rdo_thor
            // 
            this.rdo_thor.AutoSize = true;
            this.rdo_thor.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_thor.Location = new System.Drawing.Point(297, 547);
            this.rdo_thor.Name = "rdo_thor";
            this.rdo_thor.Size = new System.Drawing.Size(68, 24);
            this.rdo_thor.TabIndex = 3;
            this.rdo_thor.Text = "Thor";
            this.rdo_thor.UseVisualStyleBackColor = true;
            this.rdo_thor.CheckedChanged += new System.EventHandler(this.showpic);
            // 
            // rdo_doc
            // 
            this.rdo_doc.AutoSize = true;
            this.rdo_doc.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_doc.Location = new System.Drawing.Point(371, 547);
            this.rdo_doc.Name = "rdo_doc";
            this.rdo_doc.Size = new System.Drawing.Size(160, 24);
            this.rdo_doc.TabIndex = 4;
            this.rdo_doc.Text = "Doctor Strange\r\n";
            this.rdo_doc.UseVisualStyleBackColor = true;
            this.rdo_doc.CheckedChanged += new System.EventHandler(this.showpic);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 583);
            this.Controls.Add(this.rdo_doc);
            this.Controls.Add(this.rdo_thor);
            this.Controls.Add(this.rdo_cap);
            this.Controls.Add(this.rdo_ironman);
            this.Controls.Add(this.pic1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.RadioButton rdo_ironman;
        private System.Windows.Forms.RadioButton rdo_cap;
        private System.Windows.Forms.RadioButton rdo_thor;
        private System.Windows.Forms.RadioButton rdo_doc;
    }
}

