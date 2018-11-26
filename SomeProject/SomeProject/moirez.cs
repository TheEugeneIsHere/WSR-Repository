using System;

namespace SomeProject
{
    public partial class moirez : MetroFramework.Forms.MetroForm
    {
        public moirez()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = connection.voteTime - DateTime.Now;
            timerLabel.Text = timeremaining.Days + " дней " + timeremaining.Hours +
            " часов и " + timeremaining.Minutes + " минут до Нового Года";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            RunnerForm run = new RunnerForm();
            run.Visible = true;
        }
    }
}
