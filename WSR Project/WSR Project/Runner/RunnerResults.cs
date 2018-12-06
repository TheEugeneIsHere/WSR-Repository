using System;

namespace WSRProject
{
    public partial class RunnerResults : MetroFramework.Forms.MetroForm
    {
        public RunnerResults()
        {
            InitializeComponent();
            timer1.Start();
            metroPanel1.Visible = false;
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroPanel2.Visible = false;
            metroPanel1.Visible = true;
            label1.Text = "Насяльника на грид, толька мана запольниц треба";
        }
    }
}
