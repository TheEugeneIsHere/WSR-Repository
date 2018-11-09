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
            " часов и " + timeremaining.Minutes + " минут до сдачи курсового";
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back) { e.Handled = false; }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.BorderStyle != System.Windows.Forms.BorderStyle.Fixed3D)
            {
                pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            }
            else
            {
                pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BorderStyle != System.Windows.Forms.BorderStyle.Fixed3D)
            {
                pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
            else
            {
                pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
        }
    }
}
