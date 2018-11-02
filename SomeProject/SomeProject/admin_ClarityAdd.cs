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
    public partial class admin_ClarityAdd : MetroFramework.Forms.MetroForm
    {
        public admin_ClarityAdd()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }
        DateTime voteTime = new DateTime(2018, 11, 20, 8, 20, 0);

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = voteTime - DateTime.Now;
            metroLabel4.Text = timeremaining.Days + " дней " + timeremaining.Hours + " часов и " + timeremaining.Minutes + " минут до сдачи курсового";
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            admin_Clarity clarityForm = new admin_Clarity();
            this.Hide();
            clarityForm.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageSelector = new OpenFileDialog();
            imageSelector.Filter = "JPEG|*.jpg,*.jpeg,*.jpe,*.jfif|PNG|*.png|All files (*.*)|*.*";
            imageSelector.Title = "Выберите логотип..";
            Bitmap logo;

            if (imageSelector.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    logo = new Bitmap(imageSelector.FileName);
                    pictureBox3.Image = logo;
                    pictureBox3.Invalidate();
                    metroTextBox3.Text = imageSelector.SafeFileName;
                }
                catch
                { 
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text != "")
            {
                //Здесь что-то сложное будет, наверное
            }
            else
            {
                MessageBox.Show("Введите название организации", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
