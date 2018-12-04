using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SomeProject
{
    public partial class RunnerReg : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = Сonnection.AzureConnection();

        public RunnerReg()
        {
            InitializeComponent();
            this.Text = "MARATHON IS";
            timer1.Tick += TimerTick;
            timer1.Start();
           
        }

        private void TimerTick(object sender, EventArgs e)
        {
            Сonnection counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
          }

        private DateTime born;
        private string mail;
        private string pas;
        private string nm;
        private string fnm;
        private string gender;
        private string country;
        private int id;

        private void MetroButton2_Click(object sender, EventArgs e)
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
                nm = metroTextBox4.Text;
                fnm = metroTextBox5.Text;
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
                born.ToString("yyyy - MM - dd");

                /*запросик регистрации*/
                string query1 = "INSERT INTO Runner VALUES (N'" + mail + "',N'" + gender + "','" + born + "',N'" + country + "');";
                string query2 = "INSERT INTO Users VALUES (N'" + mail + "',N'" + nm + "',N'" + fnm + "', N'" + pas + "', N'R')";
                // По идее должно работать, хотя гарантировать я не могу. Ебанёт да не должно вроде
                Register(query1); // Сначала вставка в Runner, затем в Users
                UsersAdd(query2); 

            }
        }

        private void UsersAdd(string query)
        {
            try
            {
                con.Open();
                SqlCommand add = new SqlCommand(query, con);
                add.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void Register(string query)
        {
            try
            {
                con.Open();
                SqlCommand register = new SqlCommand(query, con);
                register.ExecuteNonQuery();
                con.Close();
                this.Close();
                Success suc = new Success();
                suc.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void MetroTextBox4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void MetroTextBox5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void MetroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
                if ((e.KeyChar >= 'А') && (e.KeyChar <= 'я'))
                {
                e.Handled = true;
                    errorProvider2.SetError(metroTextBox1, "Используйте английский язык для ввода Email");
                }
               
            
            else { errorProvider2.SetError(metroTextBox1, String.Empty); }
        }

        private void MetroTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'А') && (e.KeyChar <= 'я'))
            {
                e.Handled = true;
                errorProvider2.SetError(metroTextBox3, "Используйте английский язык для ввода Пароля");
            }
            else { errorProvider2.SetError(metroTextBox2, String.Empty); }
        }

        private void MetroTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if ((e.KeyChar >= 'А') && (e.KeyChar <= 'я'))
                {
                e.Handled = true;
                    errorProvider2.SetError(metroTextBox3, "Используйте английский язык для ввода Пароля");
                }
                
           
            else { errorProvider2.SetError(metroTextBox3, String.Empty); }
        }

        private void MetroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
          

        }
    }

    
}

