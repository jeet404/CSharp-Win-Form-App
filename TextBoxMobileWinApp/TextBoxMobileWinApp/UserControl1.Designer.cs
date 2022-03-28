namespace TextBoxMobileWinApp
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_mno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_mno
            // 
            this.txt_mno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_mno.Location = new System.Drawing.Point(5, 0);
            this.txt_mno.Name = "txt_mno";
            this.txt_mno.Size = new System.Drawing.Size(254, 29);
            this.txt_mno.TabIndex = 0;
            this.txt_mno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mno_KeyPress);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_mno);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(262, 37);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_mno;
    }
}