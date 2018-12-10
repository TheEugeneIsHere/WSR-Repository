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
    public partial class BMR : MetroFramework.Forms.MetroForm
    {
        public BMR()
        {
            InitializeComponent();
        }
        string result;
        private void metroButton1_Click(object sender, EventArgs e)
        {
           
            metroLabel12.Text = "Ваш рост: "+hCombo.Text+ " см";
            metroLabel13.Text = "Ваш вес: "+wCombo.Text + " кг";
            metroLabel14.Text = "Ваш возраст: "+yCombo.Text + " лет";
            if(hCombo.Text!="" && wCombo.Text!="" && yCombo.Text != "")
            {
                if (man)
                {
                    man_calc();
                }
                else
                {
                    woman_calc();
                }
                metroPanel1.Visible = false;
                metroLabel15.Text = "Ваш уровень метаболизма: " + result;
            }
            else
            {
                MessageBox.Show("Введите недостающие данные!");
            }
           
        }
        private void TimerTick(object sender, EventArgs e)
        {
            var counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }
        void man_calc()
        {
            double bmr = 88.362 + (13.397 * Convert.ToInt32(wCombo.Text))+(4.799*Convert.ToInt32(hCombo.Text)-(5.677*Convert.ToInt32(yCombo.Text)));
            result = Convert.ToString(bmr);
        }
        void woman_calc()
        {
             double bmr = 447.593 + (9.247 * Convert.ToInt32(wCombo.Text)) + (3.098 * Convert.ToInt32(hCombo.Text) - (4.330 * Convert.ToInt32(yCombo.Text)));
            result = Convert.ToString(bmr);
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        bool man = true;
        private void manBox_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
            man = true;
            manBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            womanBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void womanBox_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
            man =false;
            womanBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            manBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void hCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back) { e.Handled = false; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var MainForm = new Form1();
            MainForm.Show();
            Hide();
        }
    }
}
