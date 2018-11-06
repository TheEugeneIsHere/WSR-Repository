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
    public partial class regmar : MetroFramework.Forms.MetroForm
    {
        public regmar()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }
        DateTime voteTime = new DateTime(2018, 11, 20, 8, 20, 0);
        int distance = 0, stoim=0,vznos = 0, variant = 0,itog=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
             TimeSpan timeremaining = voteTime - DateTime.Now;
            metroLabel9.Text = timeremaining.Days + " дней " + timeremaining.Hours + " часов и " + timeremaining.Minutes + " минут до сдачи курсового";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RunnerForm run = new RunnerForm();
            run.Visible = true;
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked == true)
            {
                distance = 42;
                stoim = 145;
                bunifuCheckbox2.Checked = false;
                bunifuCheckbox3.Checked = false;
            }
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton1.Checked == true)
            {
                
                metroRadioButton2.Checked = false;
                metroRadioButton3.Checked = false;
            }
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton2.Checked == true)
            {
                variant = 20;
                metroRadioButton1.Checked = false;
                metroRadioButton3.Checked = false;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            vznos =Convert.ToInt32( metroTextBox2.Text);
            itog = vznos + stoim + variant;
            label1.Text = itog + "$";
            MessageBox.Show("В теории вы зареганы, по факту система не работает...","Продам гараж");
        }

        private void metroRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton3.Checked == true)
            {
                variant = 45;
                metroRadioButton2.Checked = false;
                metroRadioButton1.Checked = false;
            }
        }

        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox2.Checked == true)
            {
                distance = 21;
                stoim = 75;
                bunifuCheckbox1.Checked = false;
                bunifuCheckbox3.Checked = false;
            }
        }

        private void bunifuCheckbox3_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox3.Checked == true)
            {
                distance = 5;
                stoim = 20;
                bunifuCheckbox1.Checked = false;
                bunifuCheckbox2.Checked = false;
            }
        }
    }
}
