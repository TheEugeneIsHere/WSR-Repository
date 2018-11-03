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
    public partial class admin_UsersEdit : MetroFramework.Forms.MetroForm
    {
        public admin_UsersEdit()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }
        DateTime voteTime = new DateTime(2018, 11, 20, 8, 20, 0);
        ErrorProvider error = new ErrorProvider();

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = voteTime - DateTime.Now;
            metroLabel4.Text = timeremaining.Days + " дней " + timeremaining.Hours + " часов и " + timeremaining.Minutes + " минут до сдачи курсового";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            admin_Users UsersForm = new admin_Users();
            UsersForm.Show();
            this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            admin_Users UsersForm = new admin_Users();
            UsersForm.Show();
            this.Close();
        }

        private void metroTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != '\b')
            {
                if ((e.KeyChar >= 'А') && (e.KeyChar <= 'я'))
                {
                    MessageBox.Show("Используйте английский язык для ввода Имени", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error.SetError(metroTextBox3, "Ошибка");
                }
                e.Handled = true;
            }
            else { error.Clear(); }
        }

        private void metroTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != '\b')
            {
                if ((e.KeyChar >= 'А') && (e.KeyChar <= 'я'))
                {
                    MessageBox.Show("Используйте английский язык для ввода Фамилии", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error.SetError(metroTextBox2, "Ошибка");
                }
                e.Handled = true;
            }
            else { error.Clear(); }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox4.Text != metroTextBox5.Text)
            {
                error.SetIconAlignment(metroTextBox5, ErrorIconAlignment.MiddleLeft);
                error.SetError(metroTextBox5, "Ошибка");
                MessageBox.Show("Введённые пароли отличаются", "Введите пароль заново", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (metroComboBox2.Text == "")
            {
                error.SetError(metroComboBox2, "Ошибка");
                MessageBox.Show("Не выбрана роль пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (metroTextBox3.Text == "")
            {
                error.SetError(metroTextBox3, "Ошибка");
                MessageBox.Show("Не введено Имя пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (metroTextBox2.Text == "")
            {
                error.SetError(metroTextBox2, "Ошибка");
                MessageBox.Show("Не введена Фамилия пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroComboBox2_TextUpdate(object sender, EventArgs e)
        {
            error.Clear();
        }
        //Писос
}
}
