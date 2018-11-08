using System;

using System.Windows.Forms;
using System.Data.SqlClient;

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            metroLabel1.Text = connection.timeremaining.Days + " дней " + connection.timeremaining.Hours +
            " часов и " + connection.timeremaining.Minutes + " минут до сдачи курсового";
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
          
            ask ask = new ask();
            this.Visible = false;
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

        private void metroTile5_Click(object sender, EventArgs e)
        {
            AdminForm admOneLove = new AdminForm();
            admOneLove.Show();
            this.Hide();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            RunnerForm run = new RunnerForm();
            run.Show();
            this.Hide();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            BMIcalc calculatorForm = new BMIcalc();
            calculatorForm.Show();
            this.Hide();
        }
    }
}
