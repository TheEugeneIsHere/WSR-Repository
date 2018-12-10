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

        private void metroTile3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данные о предыдщих марафонах не найдены в БД");
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            var charorg = new Org();
            charorg.Show();
            Hide();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            var hlong= new HowLong();
            hlong.Show();
            Hide();
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
