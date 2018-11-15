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
    public partial class admin_UsersAdd : MetroFramework.Forms.MetroForm
    {
        private static string query, Role = string.Empty;
        SqlConnection con = connection.AzureConnection();

        public admin_UsersAdd()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }
        ErrorProvider error = new ErrorProvider { BlinkStyle = ErrorBlinkStyle.NeverBlink };

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = connection.voteTime - DateTime.Now;
            metroLabel4.Text = timeremaining.Days + " дней " + timeremaining.Hours +
            " часов и " + timeremaining.Minutes + " минут до сдачи курсового";
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
                    error.SetError(metroTextBox3, "Используйте английский язык для ввода Имени");
                }
                e.Handled = true;
            }
            else { error.SetError(metroTextBox3, String.Empty); }
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'А') && (e.KeyChar <= 'я'))
            {
                e.Handled = true;
                error.SetError(metroTextBox1, "Адрес электронной почты не может содержать русские буквы");
            }
            else { error.SetError(metroTextBox1, String.Empty); }
        }

        private void metroTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != '\b')
            {
                if ((e.KeyChar >= 'А') && (e.KeyChar <= 'я'))
                {
                    error.SetError(metroTextBox2, "Используйте английский язык для ввода Фамилии");
                }
                e.Handled = true;
            }
            else { error.SetError(metroTextBox2, String.Empty); }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string errorLog ="Исправьте следующие ошибки: \n\n";
            int errorCount = 0;
            SqlCommand isRegistered = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Email ='"+metroTextBox1.Text+"'", con);
            try
            {
                con.Open();
                
                if (Convert.ToString(isRegistered.ExecuteScalar()) != "0")
                {
                    error.SetError(metroTextBox1, "Ошибка");
                    ++errorCount;
                    errorLog += errorCount + ". Email-адрес уже зарегистрирован в системе\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                isRegistered.Dispose();
                con.Close();
            }

            if (metroTextBox3.Text == "")
            {
                error.SetError(metroTextBox3, "Ошибка");
                ++errorCount;
                errorLog += errorCount+". Отсутствует Имя пользователя\n";
            }

            if (metroTextBox2.Text == "")
            {
                error.SetError(metroTextBox2, "Ошибка");
                ++errorCount;
                errorLog += errorCount + ". Отсутствует Фамилия пользователя\n";
            }

            if (!metroTextBox1.Text.Contains('@'))
            {
                error.SetError(metroTextBox1, "Ошибка");
                ++errorCount;
                errorLog += errorCount + ". Неправильно введён Email-адрес\n";
            }

            if (metroComboBox2.Text == "")
            {
                error.SetError(metroComboBox2, "Ошибка");
                ++errorCount;
                errorLog += errorCount + ". Отсутствует Роль пользователя\n";
            }
            else
            {
                switch (metroComboBox2.Text)
                {
                    case "Администратор": Role = "A"; break;
                    case "Бегун": Role = "R"; break;
                    case "Координатор": Role = "C"; break;
                }
            }

            if (metroTextBox4.Text != metroTextBox5.Text)
            {
                error.SetIconAlignment(metroTextBox5,ErrorIconAlignment.MiddleLeft);
                error.SetError(metroTextBox5, "Ошибка");
                ++errorCount;
                errorLog += errorCount + ". Введённые пароли отличаются\n";
            }

            if ((metroTextBox4.Text == "") || (metroTextBox5.Text == ""))
            {
                error.SetIconAlignment(metroTextBox5, ErrorIconAlignment.MiddleLeft);
                error.SetError(metroTextBox5, "Ошибка");
                ++errorCount;
                errorLog += errorCount + ". Введите пароль\n";
            }

            if (errorCount != 0)
            {
                MessageBox.Show(errorLog, "Произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                query = "INSERT [Users] ([Email], [Password], [FirstName], [LastName], [RoleId]) VALUES" +
                        "(N'" + metroTextBox1.Text + "', N'" + metroTextBox4.Text + "', N'" + metroTextBox3.Text +
                        "', N'" + metroTextBox2.Text + "', N'" + Role + "');";

                UsersAdd(query);
            }

        }

        private void metroComboBox2_TextChanged(object sender, EventArgs e)
        {
            error.SetError(metroComboBox2, String.Empty);
        }

        private void UsersAdd(string query)
        {
            try
            {
                con.Open();
                SqlCommand register = new SqlCommand(query, con);
                register.ExecuteNonQuery();
                MessageBox.Show("Пользователь: " + metroTextBox3.Text + " добавлен в базу Информационной Системы WSR.", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
