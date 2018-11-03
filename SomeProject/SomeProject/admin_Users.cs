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
    public partial class admin_Users : MetroFramework.Forms.MetroForm
    {
        public admin_Users()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
            Random rnd = new Random();
            metroLabel3.Text = Convert.ToString(rnd.Next(100, 999)); // Ну это чисто по-приколу
            // Нада не забыть заменить её на подругзку из БД. Хотя я и так не забуду
            // Но всё равно лучше оставить здесь огромные зеленые буковки
        }
        DateTime voteTime = new DateTime(2018, 11, 20, 8, 20, 0);

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = voteTime - DateTime.Now;
            metroLabel4.Text = timeremaining.Days + " дней " + timeremaining.Hours + " часов и " + timeremaining.Minutes + " минут до сдачи курсового";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminForm admForm = new AdminForm();
            admForm.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Здесь что-то будет происходить, как можно догадаться.
            // Скорее всего обновление Грида, ибо кнопка по сути для поиска/обновления
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            admin_UsersAdd userAddForm = new admin_UsersAdd();
            userAddForm.Show();
            this.Close();
        }
    }
}
