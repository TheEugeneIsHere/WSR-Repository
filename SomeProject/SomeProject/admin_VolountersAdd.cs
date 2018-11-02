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
    public partial class admin_VolountersAdd : MetroFramework.Forms.MetroForm
    {
        public admin_VolountersAdd()
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            admin_Volounters VolountersForm = new admin_Volounters();
            VolountersForm.Show();
            this.Close();
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
        }
    }
}
