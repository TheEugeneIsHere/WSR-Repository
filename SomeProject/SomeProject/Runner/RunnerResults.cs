using System;

namespace SomeProject
{
    public partial class RunnerResults : MetroFramework.Forms.MetroForm
    {
        public RunnerResults()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            var counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            var run = new RunnerForm
            {
                Visible = true
            };
            Close();
        }

    }
}
