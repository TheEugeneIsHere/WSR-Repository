using System;
using System.Drawing;
using System.Windows.Forms;

namespace SomeProject
{
    public partial class About : MetroFramework.Forms.MetroForm
    {
        public About()
        {
            InitializeComponent();
            timer1.Start();
            LabelOnBox();
        }

        private void LabelOnBox()
        {
            pictureBox5.Size = pictureBox2.Size;
            pictureBox5.Location = new Point(0,0);
            pictureBox5.Image = Properties.Resources.map_PictureBoxLabel;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox2.Controls.Add(pictureBox5);

        }

        private void TimerTick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = Сonnection.GetTime - DateTime.Now;
            timerLabel.Text = timeremaining.Days + " дней " + timeremaining.Hours +
            " часов и " + timeremaining.Minutes + " минут до Нового Года";
        }

    
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            InfoForm InfoMenu = new InfoForm();
            InfoMenu.Show();
            Hide();
        }

        private void GoodbyeUser(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dialog = MessageBox.Show("Вы действительно желаете выйти из приложения?", "WSR: Выход",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    Application.OpenForms[0].Close();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            InteractiveMap IM = new InteractiveMap();
            IM.Show();
            Hide();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            // Изменяем на новую хуйню
        }

    }
}
