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
    public partial class aUsersEdit : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = connection.AzureConnection();
        ErrorProvider error = new ErrorProvider { BlinkStyle = ErrorBlinkStyle.NeverBlink };

        public aUsersEdit()
        {
            InitializeComponent();
            metroLabel11.Text = connection.editMail;
            GetUser();
            timer1.Tick += timer1_Tick;
            timer1.Start();
            if (userInfo3.Text == "R") { GetRunner(); }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = connection.voteTime - DateTime.Now;
            metroLabel4.Text = timeremaining.Days + " дней " + timeremaining.Hours +
            " часов и " + timeremaining.Minutes + " минут до Нового Года";
        }

        private void GetRunner()
        {
            try
            {
                SqlDataAdapter runnerInfo = new SqlDataAdapter("SELECT DateOfBirth,Gender,CountryCode FROM Runner WHERE Email = '" + metroLabel11.Text + "'", con);
                runnerInfo.Fill(wsrDataSetUsers1, "Runner");
                runnerInfo.Dispose();
                con.Close();
                runnerInfo = new SqlDataAdapter("SELECT CountryCode FROM Country", con);
                runnerInfo.Fill(wSRDataSetCountry, "getCountryCode");
                runnerInfo.Dispose();
                con.Close();
                runnerDateTime1.Value = Convert.ToDateTime(wsrDataSetUsers1.Tables[1].Rows[0][0]);
                runnerCombo1.SelectedItem = wsrDataSetUsers1.Tables[1].Rows[0][1].ToString();
                runnerCombo2.SelectedItem = wsrDataSetUsers1.Tables[1].Rows[0][2].ToString();
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

        private void GetUser()
        {
            try
            {
                SqlDataAdapter userInfo = new SqlDataAdapter("SELECT * FROM Users WHERE Email = '" + metroLabel11.Text + "'", con);
                userInfo.Fill(wsrDataSetUsers1, "Users");
                con.Close();
                userInfo.Dispose();
                userInfo1.Text = wsrDataSetUsers1.Tables[0].Rows[0][1].ToString();
                userInfo2.Text = wsrDataSetUsers1.Tables[0].Rows[0][2].ToString();
                userInfo3.SelectedItem = wsrDataSetUsers1.Tables[0].Rows[0][3].ToString();
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string errorLog = "Исправьте следующие ошибки: \n\n";
            int errorCount = 0;
            if (userInfo1.Text == "")
            {
                error.SetError(userInfo1, "Ошибка");
                ++errorCount;
                errorLog += errorCount + ". Отсутствует Имя пользователя\n";
            }

            if (userInfo2.Text == "")
            {
                error.SetError(userInfo2, "Ошибка");
                ++errorCount;
                errorLog += errorCount + ". Отсутствует Фамилия пользователя\n";
            }

            if (userInfo3.Text == "")
            {
                error.SetError(userInfo3, "Ошибка");
                ++errorCount;
                errorLog += errorCount + ". Отсутствует Роль пользователя\n";
            }

            if (metroTextBox4.Text != metroTextBox5.Text)
            {
                error.SetIconAlignment(metroTextBox5, ErrorIconAlignment.MiddleLeft);
                error.SetError(metroTextBox5, "Ошибка");
                ++errorCount;
                errorLog += errorCount + ". Введённые пароли отличаются\n";
            }

            if (errorCount != 0)
            {
                MessageBox.Show(errorLog, "Произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != '\b')
            {
                if ((e.KeyChar >= 'А') && (e.KeyChar <= 'я'))
                {
                    MessageBox.Show("Используйте английский язык для ввода Фамилии", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error.SetError(userInfo2, "Ошибка");
                }
                e.Handled = true;
            }
            else { error.SetError(userInfo2, String.Empty); }
        }

        private void metroTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != '\b')
            {
                if ((e.KeyChar >= 'А') && (e.KeyChar <= 'я'))
                {
                    MessageBox.Show("Используйте английский язык для ввода Имени", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error.SetError(userInfo1, "Ошибка");
                }
                e.Handled = true;
            }
            else { error.SetError(userInfo1, String.Empty); }
        }

        private void userInfo3_TextChanged(object sender, EventArgs e)
        {
            if (userInfo3.Text == "R")
            {
                GetRunner();
                metroPanel1.Enabled = true;
                metroPanel1.Visible = true;
            }
            else
            {
                metroPanel1.Enabled = false;
                metroPanel1.Visible = false;
            }
        }

        private void BackToUsers_Click(object sender, EventArgs e)
        {
            aUsers UsersForm = new aUsers();
            UsersForm.Show();
            this.Hide();
            this.Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 MainForm = new Form1();
            MainForm.Show();
            this.Hide();
            this.Dispose();
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
