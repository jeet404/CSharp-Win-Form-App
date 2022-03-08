namespace DataBaseConnectionDemoWinApp
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
            this.btn_con = new System.Windows.Forms.Button();
            this.btn_discon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_con
            // 
            this.btn_con.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_con.Location = new System.Drawing.Point(12, 77);
            this.btn_con.Name = "btn_con";
            this.btn_con.Size = new System.Drawing.Size(156, 52);
            this.btn_con.TabIndex = 0;
            this.btn_con.Text = "Connect";
            this.btn_con.UseVisualStyleBackColor = true;
            this.btn_con.Click += new System.EventHandler(this.btn_con_Click);
            // 
            // btn_discon
            // 
            this.btn_discon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_discon.Location = new System.Drawing.Point(174, 77);
            this.btn_discon.Name = "btn_discon";
            this.btn_discon.Size = new System.Drawing.Size(156, 52);
            this.btn_discon.TabIndex = 1;
            this.btn_discon.Text = "Disconnect";
            this.btn_discon.UseVisualStyleBackColor = true;
            this.btn_discon.Click += new System.EventHandler(this.btn_discon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(342, 195);
            this.Controls.Add(this.btn_discon);
            this.Controls.Add(this.btn_con);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_con;
        private System.Windows.Forms.Button btn_discon;
    }
}

