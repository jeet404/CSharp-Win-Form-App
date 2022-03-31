namespace TextboxMobileWinAapp
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
            this.txt_onlynum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_onlynum
            // 
            this.txt_onlynum.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_onlynum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_onlynum.Location = new System.Drawing.Point(6, 3);
            this.txt_onlynum.Name = "txt_onlynum";
            this.txt_onlynum.Size = new System.Drawing.Size(233, 26);
            this.txt_onlynum.TabIndex = 0;
            this.txt_onlynum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_onlynum_KeyPress);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_onlynum);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(245, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_onlynum;
    }
}
