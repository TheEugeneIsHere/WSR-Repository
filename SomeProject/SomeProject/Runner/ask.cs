using System;

namespace SomeProject
{
    public partial class Ask : MetroFramework.Forms.MetroForm
    {
        public Ask()
        {
            InitializeComponent();
            this.Text = "MARATHON IS";
            
            timer1.Tick += TimerTick;
            timer1.Start();

        }

        private void TimerTick(object sender, EventArgs e)
        {
            Сonnection counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            var f1 = new Form1
            {
                Visible = true
            };
            Close();
        }

        private void MetroTile1_Click(object sender, EventArgs e)
        {
            var log = new Login();
            log.Show();
            Hide();
        }

        private void MetroTile2_Click(object sender, EventArgs e)
        {
            var reg = new RunnerReg();
            reg.ShowDialog();
            Hide();
        }
    }
}
