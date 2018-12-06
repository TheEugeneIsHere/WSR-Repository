using System;

namespace WSRProject
{
    public partial class Success : MetroFramework.Forms.MetroForm
    {
        public Success()
        {
            InitializeComponent();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            var MainMenu = new Form1();
            MainMenu.Show();
            Close();
        }
    }
}
