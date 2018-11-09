using System;
using System.Data.SqlClient;
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
    public partial class registration : MetroFramework.Forms.MetroForm
    {
        public registration()
        {
            InitializeComponent();
            this.Text = "MARATHON IS";
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }
        SqlConnection con = connection.AzureConnection();
        DateTime voteTime = new DateTime(2018, 11, 20, 8, 20, 0);
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = voteTime - DateTime.Now;
            metroLabel1.Text = timeremaining.Days + " дней " + timeremaining.Hours + " часов и " + timeremaining.Minutes + " минут до сдачи курсового";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
          }

       

        private string mail;
        private string pas;
        private string nm;
        private string fnm;
        private string gender;
        private string country;
        private DateTime born;
      
        private void metroButton2_Click(object sender, EventArgs e)
        {
            int errorcount = 0;
            string errorLog = "Исправьте ошибки:\n";
            SqlCommand isRegistered = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Email ='" + metroTextBox1.Text + "'", con);
            try
            {
                con.Open();

                if (Convert.ToString(isRegistered.ExecuteScalar()) != "0")
                {
                    errorProvider2.SetError(metroTextBox1, "Ошибка");
                    errorcount++;
                    errorLog += errorcount + ". Email-адрес уже зарегистрирован в системе\n";
                }
                con.Close();
                isRegistered.Dispose();
            }
            catch (Exception ex)
            {
                isRegistered.Dispose();
                con.Close();
                MessageBox.Show(ex.ToString());
            }
            if (metroTextBox1.Text == "")
            {
                errorProvider2.SetError(metroTextBox1, "Ошибка");
                errorcount++;
                errorLog += errorcount + ". Не введен Email\n";
            }
            if (metroTextBox2.Text == "")
            {
                errorProvider2.SetError(metroTextBox2, "Ошибка");
                errorcount++;
                errorLog += errorcount + ". Не введен пароль\n";
            }
            if (metroTextBox3.Text == "")
            {
                errorProvider2.SetError(metroTextBox3, "Ошибка");
                errorcount++;
                errorLog += errorcount + ". Не введен повтор пароля\n";
            }
            if (metroTextBox4.Text == "")
            {
                errorProvider2.SetError(metroTextBox4, "Ошибка");
                errorcount++;
                errorLog += errorcount + ". Не введено имя\n";
            }
            if (metroTextBox5.Text == "")
            {
                errorProvider2.SetError(metroTextBox5, "Ошибка");
                errorcount++;
                errorLog += errorcount + ". Не введена фамилия\n";
            }
            if (metroComboBox1.Text == "")
            {
                errorProvider2.SetError(metroComboBox1, "Ошибка");
                errorcount++;
                errorLog += errorcount + ". Не выбран пол\n";
            }
            if (metroComboBox2.Text == "")
            {
                errorProvider2.SetError(metroComboBox2, "Ошибка");
                errorcount++;
                errorLog += errorcount + ". Не выбрана страна\n";
            }
            if (metroTextBox2.Text != metroTextBox3.Text)
            {
                errorProvider2.SetError(metroComboBox2, "Ошибка");
                errorcount++;
                errorLog += errorcount + ". Пароли не совпадают\n";
            }
            if (errorcount != 0)
            {
                MessageBox.Show(errorLog, "Произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mail = metroTextBox1.Text;
                pas = metroTextBox2.Text;
                nm = metroTextBox3.Text;
                fnm = metroTextBox4.Text;
                /*получение кода страны*/
                SqlCommand getCountryCode = new SqlCommand("SELECT @countrycode=countrycode FROM country WHERE countryname ='" + metroComboBox2.Text + "'", con);
                try
                {
                    con.Open();
                    SqlParameter countrycode;
                    countrycode = getCountryCode.Parameters.Add("@countrycode", SqlDbType.VarChar, 20);
                    countrycode.Direction = ParameterDirection.Output;
                    getCountryCode.ExecuteNonQuery();
                    country = Convert.ToString(countrycode.Value);
                    con.Close();
                    getCountryCode.Dispose();
                }
                catch (Exception ex)
                {
                    getCountryCode.Dispose();
                    con.Close();
                    MessageBox.Show(ex.ToString());
                }
                /**/
                gender = metroComboBox1.Text;
                born = metroDateTime1.Value;
                /*запросик регистрации*/
                //скоро завезем....
              
            }
        }

        private void metroTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != '\b')
            {
                if ((e.KeyChar >= 'А') && (e.KeyChar <= 'я'))
                {
                    errorProvider2.SetError(metroTextBox4, "Используйте английский язык для ввода Имени");
                }
                e.Handled = true;
            }
            else { errorProvider2.SetError(metroTextBox4, String.Empty); }
        }

        private void metroTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != '\b')
            {
                if ((e.KeyChar >= 'А') && (e.KeyChar <= 'я'))
                {
                    errorProvider2.SetError(metroTextBox5, "Используйте английский язык для ввода Фамилии");
                }
                e.Handled = true;
            }
            else { errorProvider2.SetError(metroTextBox5, String.Empty); }
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != '\b')
            {
                if ((e.KeyChar >= 'А') && (e.KeyChar <= 'я'))
                {
                    errorProvider2.SetError(metroTextBox1, "Используйте английский язык для ввода Email");
                }
                e.Handled = true;
            }
            else { errorProvider2.SetError(metroTextBox1, String.Empty); }
        }

        private void metroTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != '\b')
            {
                if ((e.KeyChar >= 'А') && (e.KeyChar <= 'я'))
                {
                    errorProvider2.SetError(metroTextBox2, "Используйте английский язык для ввода Пароля");
                }
                e.Handled = true;
            }
            else { errorProvider2.SetError(metroTextBox2, String.Empty); }
        }

        private void metroTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != '\b')
            {
                if ((e.KeyChar >= 'А') && (e.KeyChar <= 'я'))
                {
                    errorProvider2.SetError(metroTextBox3, "Используйте английский язык для ввода Пароля");
                }
                e.Handled = true;
            }
            else { errorProvider2.SetError(metroTextBox3, String.Empty); }
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }
    }

    
}

