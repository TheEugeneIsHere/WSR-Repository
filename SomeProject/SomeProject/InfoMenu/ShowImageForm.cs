using System;
namespace SomeProject
{
    public partial class ShowImageForm : MetroFramework.Forms.MetroForm
    {
        public ShowImageForm()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = connection.imageView;
        }
    }
}
