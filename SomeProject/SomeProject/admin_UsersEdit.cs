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
    public partial class admin_UsersEdit : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = connection.AzureConnection();

        public admin_UsersEdit()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Start();
            metroLabel11.Text = connection.editMail;
        }
       
        ErrorProvider error = new ErrorProvider { BlinkStyle = ErrorBlinkStyle.NeverBlink };

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = connection.voteTime - DateTime.Now;
            metroLabel4.Text = timeremaining.Days + " дней " + timeremaining.Hours +
            " часов и " + timeremaining.Minutes + " минут до Нового Года";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            admin_Users UsersForm = new admin_Users();
            UsersForm.Show();
            this.Hide();
            this.Dispose();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            admin_Users UsersForm = new admin_Users();
            UsersForm.Show();
            this.Hide();
            this.Dispose();
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
            else { error.SetError(metroTextBox3, String.Empty); }
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
            else { error.SetError(metroTextBox2, String.Empty); }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string errorLog = "Исправьте следующие ошибки: \n\n";
            int errorCount = 0;
            if (metroTextBox3.Text == "")
            {
                error.SetError(metroTextBox3, "Ошибка");
                ++errorCount;
                errorLog += errorCount + ". Отсутствует Имя пользователя\n";
                // MessageBox.Show("Не введено Имя пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (metroTextBox2.Text == "")
            {
                error.SetError(metroTextBox2, "Ошибка");
                ++errorCount;
                errorLog += errorCount + ". Отсутствует Фамилия пользователя\n";
                // MessageBox.Show("Не введена Фамилия пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (metroComboBox2.Text == "")
            {
                error.SetError(metroComboBox2, "Ошибка");
                ++errorCount;
                errorLog += errorCount + ". Отсутствует Роль пользователя\n";
                //MessageBox.Show("Не выбрана роль пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (metroTextBox4.Text != metroTextBox5.Text)
            {
                error.SetIconAlignment(metroTextBox5, ErrorIconAlignment.MiddleLeft);
                error.SetError(metroTextBox5, "Ошибка");
                ++errorCount;
                errorLog += errorCount + ". Введённые пароли отличаются\n";
                //MessageBox.Show("Введённые пароли отличаются", "Введите пароль заново", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (errorCount != 0)
            {
                MessageBox.Show(errorLog, "Произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroComboBox2_TextChanged(object sender, EventArgs e)
        {
            error.SetError(metroComboBox2, String.Empty);
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
