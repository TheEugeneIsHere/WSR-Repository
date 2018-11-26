using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SomeProject
{
    public partial class aUsersEdit : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = connection.AzureConnection();

        private static char Role;

        public aUsersEdit()
        {
            InitializeComponent();
            metroLabel11.Text = connection.editMail;
            GetUser();
            if (userInfo3.Text == "R")
            {
                Role = 'R';
                GetRunner();
            }

            timer1.Tick += timer1_Tick;
            timer1.Start();
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

                SqlDataAdapter runnerInfo = new SqlDataAdapter("SELECT DateOfBirth, Gender, CountryCode, RunnerId FROM Runner WHERE Email = '" + metroLabel11.Text + "'", con);
                runnerInfo.Fill(wsrDataSetUsers1, "Runner");
                runnerInfo.Dispose();
                con.Close();
                runnerInfo = new SqlDataAdapter("SELECT CountryCode FROM Country", con);
                runnerInfo.Fill(wSRDataSetCountry, "getCountryCode");
                runnerInfo.Dispose();
                con.Close();
                if (wsrDataSetUsers1.Tables[1].Rows.Count >= 1)
                {
                    runnerDateTime1.Value = Convert.ToDateTime(wsrDataSetUsers1.Tables[1].Rows[0][0]);
                    runnerCombo1.SelectedItem = wsrDataSetUsers1.Tables[1].Rows[0][1].ToString();
                    runnerCombo2.Text = wsrDataSetUsers1.Tables[1].Rows[0][2].ToString();
                    if (wsrDataSetUsers1.Tables[1].Rows[0][3].ToString() == "R") Role = 'R';
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

        private void UpdateUser()
        {
            string query = null;
            query = "UPDATE Users " +
                    "SET FirstName = '" + userInfo1.Text + "'," +
                    " LastName = '" + userInfo2.Text + "'," +
                    " RoleId = '" + userInfo3.Text + "' ";
            if ((metroTextBox4.Text!="" && metroTextBox5.Text!="") && (metroTextBox4.Text == metroTextBox5.Text))
            {
                query += ",Password = '" + metroTextBox4.Text + "' ";
            }
            query += "WHERE Email ='" + metroLabel11.Text + "'; ";

            if (metroPanel1.Enabled)
            {
                query += "UPDATE Runner " +
                    "SET DateOfBirth = '" + runnerDateTime1.Value.ToString("yyyy-MM-dd") + "'," +
                    " Gender = '" + runnerCombo1.Text + "'," +
                    " CountryCode = '" + runnerCombo2.Text + "' " +
                    "WHERE Email ='" + metroLabel11.Text + "'; ";
            }
            else
            {
                
                if (Role == 'R') // Sponsorship -> RegistrationEvent -> Registration -> Runner
                { 
                    query += "DELETE FROM Sponsorship WHERE RegistrationId =" + 
                        " (SELECT RegistrationId FROM Registration WHERE RunnerId = " +
                        "(SELECT RunnerId FROM Runner WHERE Email = '" + metroLabel11.Text + "')); ";
                    // При обновлении Бегуна на другую роль этот код удаляет его из 4 таблиц (удаление дубликата с R-ролью)
                    query += "DELETE FROM RegistrationEvent WHERE RegistrationId =" + 
                        " (SELECT RegistrationId FROM Registration WHERE RunnerId = " +
                        "(SELECT RunnerId FROM Runner WHERE Email = '" + metroLabel11.Text + "')); ";
                    // Порядок удаления нельзя менять, конфликты FK
                    query += "DELETE FROM Registration WHERE RunnerId = '" + wsrDataSetUsers1.Tables[1].Rows[0][3].ToString() + "';" +
                        " DELETE FROM Runner WHERE Email = '" + metroLabel11.Text + "'; ";
                }
            }

            try
            {
                con.Open();
                SqlCommand updateQuery = new SqlCommand(query, con);
                updateQuery.ExecuteNonQuery();
                MessageBox.Show("Информация пользователя "+userInfo1.Text+" успешно обновлена.","WSR: Обновление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
                aUsers UsersForm = new aUsers();
                UsersForm.Show();
                this.Hide();
                this.Dispose();
                Role = '\0';
            }
        }

        private void updateUser_Click(object sender, EventArgs e)
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
                MessageBox.Show(errorLog, "WSR: Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorCount = 0;
            }
            else
            {
                UpdateUser();
            }

        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("dbo.sp_DeleteUser", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter userMail = new SqlParameter
                {
                    ParameterName = "@email",
                    Value = connection.editMail
                };
                command.Parameters.Add(userMail);
                command.ExecuteNonQuery();
                MessageBox.Show("Пользователь успешно удалён!", "WSR: Удаление",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                aUsers UsersForm = new aUsers();
                this.Hide();
                this.Dispose();
                UsersForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
            finally
            {
                con.Close();
            }
        }

        private void userInfo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != '\b')
            {
                if ((e.KeyChar >= 'А') && (e.KeyChar <= 'я'))
                {
                    error.SetError(userInfo1, "Используйте английский язык для ввода Имени");
                }
                e.Handled = true;
            }
            else { error.SetError(userInfo1, String.Empty); }
        }

        private void userInfo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'z') && e.KeyChar != '\b')
            {
                if ((e.KeyChar >= 'А') && (e.KeyChar <= 'я'))
                { 
                    error.SetError(userInfo2, "Используйте английский язык для ввода Фамилии");
                }
                e.Handled = true;
            }
            else { error.SetError(userInfo2, String.Empty); }
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

        private void logoutPic_Click(object sender, EventArgs e)
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
