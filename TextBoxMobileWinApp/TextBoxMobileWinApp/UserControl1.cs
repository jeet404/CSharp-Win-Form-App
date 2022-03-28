namespace TextBoxMobileWinApp
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void txt_mno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(e.KeyChar > 48 && e.KeyChar < 57 || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }
    }
}