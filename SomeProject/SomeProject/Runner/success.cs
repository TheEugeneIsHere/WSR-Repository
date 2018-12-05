using System;

namespace SomeProject
{
    public partial class Success : MetroFramework.Forms.MetroForm
    {
        public Success()
        {
            InitializeComponent();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            var f1 = new Form1();
            f1.Show();
            Close();
        }
    }
}
