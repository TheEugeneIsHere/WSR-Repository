using System;

using System.Windows.Forms;

namespace SomeProject
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
          
        }
        DateTime voteTime = new DateTime(2018, 11, 20, 8, 20, 0);
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = voteTime - DateTime.Now;
            metroLabel1.Text = timeremaining.Days + " дней " + timeremaining.Hours + " часов и " + timeremaining.Minutes + " минут до сдачи курсового";
        }
        //ну допустим...
        private void metroTile1_Click(object sender, EventArgs e)
        {
            ask ask = new ask();
            this.Hide();
            ask.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
        }
    }
}
