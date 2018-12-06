using System;
using System.Windows.Forms;

namespace WSRProject
{
    public partial class InfoForm : MetroFramework.Forms.MetroForm
    {
        public InfoForm()
        {
            InitializeComponent();
            timer1.Start();
            FormClosing += new FormClosingEventHandler(AppClose.GoodBye);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            var counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            var MainMenu = new Form1();
            MainMenu.Show();
            Hide();
        }

        private void MetroTile1_Click(object sender, EventArgs e)
        {
            var about = new About();
            about.Show();
            Hide();
        }

    }
}
