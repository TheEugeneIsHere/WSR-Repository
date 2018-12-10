using System;
using System.Drawing;
using System.Threading;

namespace WSRProject
{
    public partial class InteractiveMap : MetroFramework.Forms.MetroForm
    {
        public InteractiveMap()
        {
            InitializeComponent();
        
        }
        private void TimerTick(object sender, EventArgs e)
        {
            var counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }

        private void pictureBox8_Click(object sender, System.EventArgs e)
        {
            label1.Text = "Туалет";
           
           
        }

        private void pictureBox3_Click(object sender, System.EventArgs e)
        {
            label1.Text = "Пункт выдачи энергетических батончиков, напитков";
        
        }

        private void pictureBox4_Click(object sender, System.EventArgs e)
        {
            label1.Text = "Медицинский пункт";
        
        }

        private void pictureBox5_Click(object sender, System.EventArgs e)
        {
            label1.Text = "Стойка информации";
        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            label1.Text = "Начало марафона";
        }

        private void pictureBox6_Click(object sender, System.EventArgs e)
        {
            label1.Text = "Пункт выдачи напитков";
        }

        private void pictureBox2_Click(object sender, System.EventArgs e)
        {
            var info = new InfoForm();
            info.Show();
            Hide();
        }
    }
}
