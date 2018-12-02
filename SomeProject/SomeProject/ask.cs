﻿using System;

namespace SomeProject
{
    public partial class ask : MetroFramework.Forms.MetroForm
    {
        public ask()
        {
            InitializeComponent();
            this.Text = "MARATHON IS";
            
            timer1.Tick += timer1_Tick;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = Сonnection.GetTime - DateTime.Now;
            timerLabel.Text = timeremaining.Days + " дней " + timeremaining.Hours +
            " часов и " + timeremaining.Minutes + " минут до Нового Года";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Close();
            f1.Visible=true;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            registration reg = new registration();
            this.Hide();
            reg.ShowDialog();
        }
    }
}
