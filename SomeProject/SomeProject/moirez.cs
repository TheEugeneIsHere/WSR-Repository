﻿using System;

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
            Сonnection counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            RunnerForm run = new RunnerForm();
            run.Visible = true;
        }
    }
}
