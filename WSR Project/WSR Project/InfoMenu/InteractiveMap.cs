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
            pictureBox7.Controls.Add(pictureBox15);
            pictureBox15.Location = new Point(100, 234);
            timer1.Start();
        }
        private void TimerTick(object sender, EventArgs e)
        {
            var counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }

        private void PictureBox2_Click(object sender, System.EventArgs e)
        {
            var info = new InfoForm();
            info.Show();
            Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = false;
            label1.Visible = true;
        }

        private void PictureBox4_Click_1(object sender, EventArgs e)
        {
            metroLabel8.Text = "Пункт №1";
            metroLabel2.Visible = true;
            metroLabel3.Visible = true;
            metroLabel4.Visible = false;
            metroLabel5.Visible = false;
            metroLabel6.Visible = false;

            metroPanel1.Visible = true;

            label1.Visible = false;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox9.Image = Properties.Resources.map_icon_drinks;
            pictureBox10.Image = Properties.Resources.map_icon_energy_bars;
            metroLabel2.Text = " - Энергетические \nнапитки";
            metroLabel3.Text = " - Энергетические \nбатончки";
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            metroLabel8.Text = "Пункт №2";
            metroLabel2.Visible = true;
            metroLabel3.Visible = true;
            metroLabel4.Visible = true;
            metroLabel5.Visible = true;
            metroLabel6.Visible = true;
            metroPanel1.Visible = true;
            label1.Visible = false;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox9.Image = Properties.Resources.map_icon_drinks;
            pictureBox10.Image = Properties.Resources.map_icon_energy_bars;
            pictureBox11.Image = Properties.Resources.map_icon_toilets;
            pictureBox12.Image = Properties.Resources.map_icon_information;
            pictureBox13.Image = Properties.Resources.map_icon_medical;
            metroLabel2.Text = " - Энергетические \nнапитки";
            metroLabel3.Text = " - Энергетические \nбатончики";
            metroLabel4.Text = " - Туалеты";
            metroLabel5.Text = " - Стойка \nинформации";
            metroLabel6.Text = " - Медицинская \nпомощь";
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            metroLabel8.Text = "Пункт №3";
            metroLabel2.Visible = true;
            metroLabel3.Visible = true;
            metroLabel4.Visible = true;
            metroLabel5.Visible = false;
            metroLabel6.Visible = false;
            metroPanel1.Visible = true;
            label1.Visible = false;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox9.Image = Properties.Resources.map_icon_drinks;
            pictureBox10.Image = Properties.Resources.map_icon_energy_bars;
            pictureBox11.Image = Properties.Resources.map_icon_toilets;
            metroLabel2.Text = " - Энергетические \nнапитки";
            metroLabel3.Text = " - Энергетические \nбатончики";
            metroLabel4.Text = " - Туалеты";
          
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            metroLabel8.Text = "Пункт №4";
            metroLabel2.Visible = true;
            metroLabel3.Visible = true;
            metroLabel4.Visible = true;
            metroLabel5.Visible = true;
            metroLabel6.Visible = false;
            metroPanel1.Visible = true;
            label1.Visible = false;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = false;
            pictureBox9.Image = Properties.Resources.map_icon_drinks;
            pictureBox10.Image = Properties.Resources.map_icon_energy_bars;
            pictureBox11.Image = Properties.Resources.map_icon_toilets;
            pictureBox12.Image = Properties.Resources.map_icon_information;
            pictureBox13.Image = Properties.Resources.map_icon_medical;
            metroLabel2.Text = " - Энергетические \nнапитки";
            metroLabel3.Text = " - Энергетические \nбатончики";
            metroLabel4.Text = " - Туалеты";
            metroLabel5.Text = " - Стойка \nинформации";
         
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            metroLabel8.Text = "Пункт №6";
            metroLabel2.Visible = true;
            metroLabel3.Visible = true;
            metroLabel4.Visible = false;
            metroLabel5.Visible = false;
            metroLabel6.Visible = false;

            metroPanel1.Visible = true;

            label1.Visible = false;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox9.Image = Properties.Resources.map_icon_drinks;
            pictureBox10.Image = Properties.Resources.map_icon_energy_bars;
            metroLabel2.Text = " - Энергетические \nнапитки";
            metroLabel3.Text = " - Энергетические \nбатончки";
        }

        private void PictureBox15_Click(object sender, EventArgs e)
        {
            metroLabel8.Text = "Начало марафона";
            metroLabel2.Visible = true;
            metroLabel3.Visible = false;
            metroLabel4.Visible = false;
            metroLabel5.Visible = false;
            metroLabel6.Visible = false;
            metroPanel1.Visible = true;
            label1.Visible = false;
            pictureBox9.Visible = true;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox9.Image = Properties.Resources.map_icon_start;
           
            metroLabel2.Text = " - НАЧАЛО \nМАРАФОНА";
           
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            metroLabel8.Text = "Пункт №5";
            metroLabel2.Visible = true;
            metroLabel3.Visible = true;
            metroLabel4.Visible = true;
            metroLabel5.Visible = true;
            metroLabel6.Visible = true;
            metroPanel1.Visible = true;
            label1.Visible = false;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox9.Image = Properties.Resources.map_icon_drinks;
            pictureBox10.Image = Properties.Resources.map_icon_energy_bars;
            pictureBox11.Image = Properties.Resources.map_icon_toilets;
            pictureBox12.Image = Properties.Resources.map_icon_information;
            pictureBox13.Image = Properties.Resources.map_icon_medical;
            metroLabel2.Text = " - Энергетические \nнапитки";
            metroLabel3.Text = " - Энергетические \nбатончики";
            metroLabel4.Text = " - Туалеты";
            metroLabel5.Text = " - Стойка \nинформации";
            metroLabel6.Text = " - Медицинская \nпомощь";
        }
    }
}
