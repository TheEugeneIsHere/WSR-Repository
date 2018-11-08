using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeProject
{
    public partial class admin_CharityAdd : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = connection.AzureConnection();

        public admin_CharityAdd()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            metroLabel4.Text = connection.timeremaining.Days + " дней " + connection.timeremaining.Hours +
            " часов и " + connection.timeremaining.Minutes + " минут до сдачи курсового";
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            admin_Charity clarityForm = new admin_Charity();
            clarityForm.Show();
            this.Close();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageSelector = new OpenFileDialog
            {
                Filter = "JPEG|*.jpg,*.jpeg,*.jpe,*.jfif|PNG|*.png|All files (*.*)|*.*",
                Title = "Выберите логотип.."
            };
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            admin_Charity adminMenu_Clarity = new admin_Charity();
            adminMenu_Clarity.Show();
            this.Close();
        }
    }
}
