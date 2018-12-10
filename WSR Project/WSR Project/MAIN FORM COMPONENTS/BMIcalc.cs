using System;
using System.Drawing;
using System.Windows.Forms;

namespace WSRProject
{
    public partial class BMIcalc : MetroFramework.Forms.MetroForm
    {
        string gender;

        public BMIcalc()
        {
            InitializeComponent();
            timer1.Start();
            FormClosing += new FormClosingEventHandler(AppClose.GoodBye);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            var counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }

        private void WomanBoxClicked(object sender, EventArgs e)
        {
            gender = "Woman";
            Control();
            womanBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            manBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            healthStatePic.Image = Properties.Resources.bmiWomanDefault;
        }

        private void ManBoxClicked(object sender, EventArgs e)
        {
            gender = "Man";
            Control();
            manBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            womanBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            healthStatePic.Image = Properties.Resources.bmiManDefault;
        }

        private void MetroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back) { e.Handled = false; }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            var MainForm = new Form1();
            MainForm.Show();
            Hide();
        }

        private void Control()
        {
            imtTextLabel.Visible = false;
            imtLabel.Visible = false;
            hCombo.Enabled = true;
            wCombo.Enabled = true;
            metroButton1.Enabled = true;
            hCombo.Text = null;
            wCombo.Text = null;
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            if (hCombo.Text != "" && wCombo.Text != "")
            {
                double H = Convert.ToDouble(hCombo.Text) / 100.0;
                double W = Convert.ToInt32(wCombo.Text);
                string result;
                double imtResult = W / (Math.Pow(H, 2));
                MeasureResults(imtResult);
                result = string.Format("{0:##.##}", imtResult);
                imtLabel.Text = result;
                imtLabel.Visible = true;
                imtTextLabel.Visible = true;
            }
        }

        private void MeasureResults(double imt)
        {
            if (imt < 16)
            {
                imtLabel.ForeColor = Color.Blue;
                imtTextLabel.ForeColor = Color.Blue;
                imtTextLabel.Text = "Выраженный дефицит массы";
                switch (gender)
                {
                    case "Man": healthStatePic.Image = Properties.Resources.bmiManLack; break;
                    case "Woman": healthStatePic.Image = Properties.Resources.bmiWomanLack; break;
                }
            }

            if (imt > 16 && imt < 18.5)
            {
                imtLabel.ForeColor = Color.Red;
                imtTextLabel.ForeColor = Color.Red;
                imtTextLabel.Text = "Дефицит массы тела";
                switch (gender)
                {
                    case "Man": healthStatePic.Image = Properties.Resources.bmiManLack; break;
                    case "Woman": healthStatePic.Image = Properties.Resources.bmiWomanLack; break;
                }
            }

            if (imt > 18.5 && imt < 25)
            {
                imtLabel.ForeColor = Color.DarkGreen;
                imtTextLabel.ForeColor = Color.DarkGreen;
                imtTextLabel.Text = "Норма";
                switch (gender)
                {
                    case "Man": healthStatePic.Image = Properties.Resources.bmiManGood; break;
                    case "Woman": healthStatePic.Image = Properties.Resources.bmiWomanGood; break;
                }
            }

            if (imt > 25 && imt < 30)
            {
                imtLabel.ForeColor = Color.DarkOrange;
                imtTextLabel.ForeColor = Color.DarkOrange;
                imtTextLabel.Text = "Избыточная масса тела";
                switch (gender)
                {
                    case "Man": healthStatePic.Image = Properties.Resources.bmiManSoSo; break;
                    case "Woman": healthStatePic.Image = Properties.Resources.bmiWomanSoSo; break;
                }
            }

            if (imt > 30)
            {
                imtLabel.ForeColor = Color.Red;
                imtTextLabel.ForeColor = Color.Red;
                imtTextLabel.Text = "Ожирение (1 стадия и выше)";
                switch (gender)
                {
                    case "Man": healthStatePic.Image = Properties.Resources.bmiManBad; break;
                    case "Woman": healthStatePic.Image = Properties.Resources.bmiWomanBad; break;
                }
            }

        }

    }
}
