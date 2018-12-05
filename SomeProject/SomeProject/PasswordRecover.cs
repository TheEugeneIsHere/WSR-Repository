using System;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SomeProject
{
    public partial class PasswordRecover : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = Сonnection.AzureConnection();

        public PasswordRecover() // Подгончик для Максюши. +200 к увОжению от Савиной
        {
            InitializeComponent();
        }

        bool IsValidEmail(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            if (IsValidEmail(metroTextBox1.Text))
            {
                SendMail();
                MessageBox.Show("Данные для входа отправлены на Ваш электронный адрес", "WSR: Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Hide();
            }
            else
            {
                MessageBox.Show("Неправильно введён Email-адрес", "WSR: Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendMail()
        {
            string email, query, password;
            email = metroTextBox1.Text;
            query = "SELECT COUNT(*) FROM Users WHERE Email ='" + email + "';";
            try
            {
                con.Open();
                var request = new SqlCommand(query, con);
                if (Convert.ToInt32(request.ExecuteScalar()) != 0)
                {
                    var client = new SmtpClient("smtp.gmail.com", 25)
                    {
                        EnableSsl = true,
                        Credentials = new NetworkCredential("wsrsystems@gmail.com", "WSRpolitex")
                    };

                    request.CommandText = "SELECT Password FROM Users WHERE Email = '" + email + "';";
                    password = request.ExecuteScalar().ToString();
                    client.Send("wsrsystems@gmail.com", email, "WSR: Восстановление пароля",
                        "Данные для входа в систему WSR\n\nЛогин: " + email + "\nПароль: " + password);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally
            {
                con.Close();
            }
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
