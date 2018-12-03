using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SomeProject
{
    public partial class aUsersAdd : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = Сonnection.AzureConnection();
        private static string query;
        private static char Role;
        
        public aUsersAdd()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void UsersAdd(string query)
        {
            try
            {
                con.Open();
                SqlCommand register = new SqlCommand(query, con);
                register.ExecuteNonQuery();
                MessageBox.Show("Пользователь: " + metroTextBox3.Text + " добавлен в базу Информационной Системы WSR.", "WSR: Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                aUsers usersForm = new aUsers();
                usersForm.Show();
                Hide();
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

        bool IsValidEmail(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

        private void MetroPanelToggle(object sender, EventArgs e)
        {
            error.SetError(metroComboBox2, string.Empty);
            if (metroComboBox2.Text == "Бегун")
            {
                metroPanel1.Visible = true;
                metroPanel1.Enabled = true;
            }
            else
            {
                metroPanel1.Visible = false;
                metroPanel1.Enabled = false;
            }
        }

        private void TimerTick(object sender, EventArgs e)
        {
            Сonnection counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }

        private void MetroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'А') && (e.KeyChar <= 'я'))
            {
                e.Handled = true;
                error.SetError(metroTextBox1, "Адрес электронной почты не может содержать русские буквы");
            }
            else { error.SetError(metroTextBox1, string.Empty); }
        }

        private void MetroTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != '\b')
            {
                if ((e.KeyChar >= 'А') && (e.KeyChar <= 'я'))
                {
                    error.SetError(metroTextBox2, "Используйте английский язык для ввода Фамилии");
                }
                e.Handled = true;
            }
            else { error.SetError(metroTextBox2, string.Empty); }
        }

        private void MetroTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != '\b')
            {
                if ((e.KeyChar >= 'А') && (e.KeyChar <= 'я'))
                {
                    error.SetError(metroTextBox3, "Используйте английский язык для ввода Имени");
                }
                e.Handled = true;
            }
            else { error.SetError(metroTextBox3, string.Empty); }
        }

        private void AddQuery_Click(object sender, EventArgs e)
        {
            string errorLog = "Исправьте следующие ошибки: \n\n";
            int errorCount = 0;
            SqlCommand isRegistered = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Email ='" + metroTextBox1.Text + "'", con);

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
                con.Close();
            }

            if (metroTextBox3.Text == "")
            {
                error.SetError(metroTextBox3, "Ошибка");
                ++errorCount;
                errorLog += errorCount + ". Отсутствует Имя пользователя\n";
            }

            if (metroTextBox2.Text == "")
            {
                error.SetError(metroTextBox2, "Ошибка");
                ++errorCount;
                errorLog += errorCount + ". Отсутствует Фамилия пользователя\n";
            }

            if (!IsValidEmail(metroTextBox1.Text))
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
                    case "Администратор": Role = 'A'; break;
                    case "Бегун": Role = 'R'; break;
                    case "Координатор": Role = 'C'; break;
                }
            }

            if (metroTextBox4.Text != metroTextBox5.Text)
            {
                error.SetIconAlignment(metroTextBox5, ErrorIconAlignment.MiddleLeft);
                error.SetError(metroTextBox5, "Ошибка");
                ++errorCount;
                errorLog += errorCount + ". Введённые пароли отличаются\n";
            }

            if (metroPanel1.Enabled)
            {
                if (runnerCombo1.Text == "")
                {
                    error.SetIconAlignment(runnerCombo1, ErrorIconAlignment.MiddleLeft);
                    error.SetError(runnerCombo1, "Ошибка");
                    ++errorCount;
                    errorLog += errorCount + ". Не указан пол пользователя-бегуна\n";
                }

                if (runnerCombo2.Text == "")
                {
                    error.SetIconAlignment(runnerCombo2, ErrorIconAlignment.MiddleLeft);
                    error.SetError(runnerCombo2, "Ошибка");
                    ++errorCount;
                    errorLog += errorCount + ". Не указана страна пользователя-бегуна\n";
                }
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
                MessageBox.Show(errorLog, "WSR: Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                query = "INSERT INTO Users VALUES " +
                        "(N'" + metroTextBox1.Text + "', N'" + metroTextBox4.Text + "', N'" + metroTextBox3.Text +
                        "', N'" + metroTextBox2.Text + "', N'" + Role + "');";

                if (metroPanel1.Enabled)
                {
                    SqlCommand getCode = new SqlCommand("SELECT CountryCode FROM Country WHERE CountryName = '" + runnerCombo2.Text + "'", con);
                    string gender, countryCode;
                    gender = countryCode = "";
                    try
                    {
                        con.Open();
                        countryCode = getCode.ExecuteScalar().ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        con.Close();
                    }
                    if (runnerCombo1.Text == "Мужской") { gender = "Male"; } else { gender = "Female"; }

                    query += "INSERT INTO Runner VALUES " +
                        "(N'" + metroTextBox1.Text + "', N'" + gender + "', '" + runnerDateTime1.Value.ToString("yyyy-MM-dd") +
                        "', N'" + countryCode + "');";
                }

                UsersAdd(query);
            }

        }

        private void MetroPanel1_EnabledChanged(object sender, EventArgs e)
        {
            if (metroPanel1.Enabled)
            {
                try
                {
                    con.Open();
                    SqlDataAdapter ad = new SqlDataAdapter("SELECT CountryName FROM Country", con);
                    ad.Fill(wSRDataSetCountry, "getCountryName");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void BackToUsers_Click(object sender, EventArgs e)
        {
            aUsers UsersForm = new aUsers();
            UsersForm.Show();
            Hide();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Form1 MainForm = new Form1();
            MainForm.Show();
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

    }
}
