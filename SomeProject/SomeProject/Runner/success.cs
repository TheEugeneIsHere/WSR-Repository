using System;

namespace SomeProject
{
    public partial class success : MetroFramework.Forms.MetroForm
    {
        public success()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
