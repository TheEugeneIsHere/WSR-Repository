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
    public partial class admin_VolunteerAdd : MetroFramework.Forms.MetroForm
    {
        public admin_VolunteerAdd()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = connection.voteTime - DateTime.Now;
            metroLabel4.Text = timeremaining.Days + " дней " + timeremaining.Hours +
            " часов и " + timeremaining.Minutes + " минут до сдачи курсового";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            admin_Volunteer VolountersForm = new admin_Volunteer();
            VolountersForm.Show();
            this.Hide();
            this.Dispose();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog volounterSelector = new OpenFileDialog
            {
                Filter = "Все файлы Excel”|*.xl,*.xlsx,*.xlsm..|CSV|*.csv",
                Title = "Выберите файл с волонтёрами.."
            };

            if (volounterSelector.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    metroTextBox1.Text = volounterSelector.SafeFileName;
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            // И здеся что-то будет происходить, сложно.
            // Ну если в кратце, там будет производиться загрузка чубриков в базу
            // Если она прошла успешно MessageBox что успешно и кек вроде
            // Можно ещё ProgressBar замутить куда-нить для интима, ну хз
            MessageBox.Show("Этого произойти было не должно"); // Ну а вдруг я что-то не так понял
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

    }
}
