using System;

namespace SomeProject
{
    public partial class editrunnerprofile : MetroFramework.Forms.MetroForm
    {
        public editrunnerprofile()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = Сonnection.GetTime - DateTime.Now;
            timerLabel.Text = timeremaining.Days + " дней " + timeremaining.Hours +
            " часов и " + timeremaining.Minutes + " минут до Нового Года";
        }



        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            RunnerForm run = new RunnerForm();
            run.Visible = true;
        }
    }
}
