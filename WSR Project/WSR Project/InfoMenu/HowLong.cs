using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSRProject
{
    public partial class HowLong : MetroFramework.Forms.MetroForm
    {
        public HowLong()
        {
            InitializeComponent();

            label1.Text = "Со скоростью автомобиля F1-345км/ч можно пройти марафон за 7 минут 20 секунд";
            pictureBox2.Image = Properties.Resources.f1_car;
            metroTabPage2.Select();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var run = new InfoForm
            {
                Visible = true
            };
            Hide();
        }

        private void HowLong_Load(object sender, EventArgs e)
        {

        }
        private void TimerTick(object sender, EventArgs e)
        {
            var counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label1.Text = "Со скоростью автомобиля F1-345км/ч можно пройти марафон за 7 минут 20 секунд";
            pictureBox2.Image = Properties.Resources.f1_car;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label1.Text = "Со скоростью червя-0,03 км/ч можно пройти марафон за 14 лет";
            pictureBox2.Image = Properties.Resources.worm;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label1.Text = "Со скоростью ленивца-0,13 км/ч можно пройти марафон за 2 года";
            pictureBox2.Image = Properties.Resources.sloth;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label1.Text = "Со скоростью капибары-35 км/ч можно пройти марафон за 1 час 30 минут";
            pictureBox2.Image = Properties.Resources.capybara;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label1.Text = "Со скоростью ягуара-80 км/ч можно пройти марафон за 30 минут";
            pictureBox2.Image = Properties.Resources.jaguar;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            label1.Text = "Длина марафона сопоставима с 589 Airbus a380";
            pictureBox2.Image = Properties.Resources.airbus_a380;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            label1.Text = "Длина марафона сопоставима со 179 166 Havaianas";
            pictureBox2.Image = Properties.Resources.pair_of_havaianas;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            label1.Text = "Длина марафона сопоставима со 139 фубольными полями";
            pictureBox2.Image = Properties.Resources.football_field;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            label1.Text = "Длина марафона сопоставима с ростом 23 576 Рональдо";
            pictureBox2.Image = Properties.Resources.ronaldinho;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            label1.Text = "Длина марафона сопоставима с длиной  4300  автобусов";
            pictureBox2.Image = Properties.Resources.bus;
        }
    }
}
