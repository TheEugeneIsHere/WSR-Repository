using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeProject
{
    public partial class BMIcalc : MetroFramework.Forms.MetroForm
    {
        public BMIcalc()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 MainForm = new Form1();
            MainForm.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = connection.voteTime - DateTime.Now;
            metroLabel4.Text = timeremaining.Days + " дней " + timeremaining.Hours +
            " часов и " + timeremaining.Minutes + " минут до Нового Года";
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back) { e.Handled = false; }
        }
        private static string gender;

        private void manBoxClicked(object sender, EventArgs e)
        {
            gender = "Man";
            imtLabel.Visible = false;
            manBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            womanBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            healthStatePic.Image = Properties.Resources.bmiManDefault;
        }
        
        private void womanBoxClicked(object sender,EventArgs e)
        {
            gender = "Woman";
            imtLabel.Visible = false;
            womanBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            manBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            healthStatePic.Image = Properties.Resources.bmiWomanDefault;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (hCombo.Text != "" && wCombo.Text != "")
            {
                if (Convert.ToInt32(hCombo.Text) > 220 || Convert.ToInt32(hCombo.Text) < 50)
                {
                    MessageBox.Show("Рост не может быть <50 см или >220 см", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                if (Convert.ToInt32(wCombo.Text) < 20 || Convert.ToInt32(wCombo.Text) > 200)
                {
                    MessageBox.Show("Вес не может быть <20 кг или >200 кг", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    double H = Convert.ToDouble(hCombo.Text) / 100.0;
                    double W = Convert.ToInt32(wCombo.Text);
                    string result;
                    double imtResult = W / (Math.Pow(H, 2));
                    MeasureResults(imtResult);
                    result = string.Format("{0:##.##}", imtResult);
                    imtLabel.Text = result;
                    imtLabel.Visible = true;
                }
            }
        }

        private void MeasureResults(double imt)
        {
            if (imt > 16 && imt <18.5)
            {
                imtLabel.ForeColor = Color.Red;
                if (gender == "Man")
                {
                    healthStatePic.Image = Properties.Resources.bmiManLack;
                }
                else
                {
                    healthStatePic.Image = Properties.Resources.bmiWomanLack;
                }
            }

            if (imt >18.5 && imt < 24.99)
            {
                imtLabel.ForeColor = Color.Green;
                if (gender == "Man")
                {
                    healthStatePic.Image = Properties.Resources.bmiManGood;
                }
                else
                {
                    healthStatePic.Image = Properties.Resources.bmiWomanGood;
                }
            }

            if (imt>25 && imt<30)
            {
                imtLabel.ForeColor = Color.Yellow;
                if (gender == "Man")
                {
                    healthStatePic.Image = Properties.Resources.bmiManSoSo;
                }
                else
                {
                    healthStatePic.Image = Properties.Resources.bmiWomanSoSo;
                }
            }

            if (imt>30)
            {
                imtLabel.ForeColor = Color.Red;
                if (gender == "Man")
                {
                    healthStatePic.Image = Properties.Resources.bmiManBad;
                }
                else
                {
                    healthStatePic.Image = Properties.Resources.bmiWomanBad;
                }
            }

        }
    }
}
