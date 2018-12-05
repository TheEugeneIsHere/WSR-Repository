using System;
using System.Drawing;
using System.Windows.Forms;

namespace SomeProject
{
    public partial class About : MetroFramework.Forms.MetroForm
    {
        public About()
        {
            InitializeComponent();
            timer1.Start();
            LabelOnBox();
            FormClosing += new FormClosingEventHandler(AppClose.GoodBye);
        }

        private void LabelOnBox()
        {
            pictureBox5.Size = pictureBox2.Size;
            pictureBox5.Location = new Point(0,0);
            pictureBox5.Image = Properties.Resources.map_PictureBoxLabel;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox2.Controls.Add(pictureBox5);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            var counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }

    
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            var InfoMenu = new InfoForm();
            InfoMenu.Show();
            Hide();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            var IM = new InteractiveMap();
            IM.Show();
            Hide();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            // Изменяем на новую хуйню
        }

    }
}
