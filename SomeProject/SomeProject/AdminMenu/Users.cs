using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SomeProject
{
    public partial class aUsers : MetroFramework.Forms.MetroForm
    {
        private static string query = "SELECT FirstName, LastName, Email, RoleID FROM Users";
        SqlConnection con = Сonnection.AzureConnection();

        public aUsers()
        {
            InitializeComponent();
            UsersCount();
            UsersLoad(query);
            timer1.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            Сonnection counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }

        private void UsersCount()
        {
            try
            {
                con.Open();
                SqlCommand usersCount = new SqlCommand("SELECT COUNT(*) FROM Users", con);
                metroLabel3.Text = usersCount.ExecuteScalar().ToString();
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

        private void UsersLoad(string query)
        {
            try
            {
                con.Open();
                SqlDataAdapter ad = new SqlDataAdapter(query, con);
                ad.Fill(wSRDataSetUsers, "Users");
                metroGrid1.DataSource = wSRDataSetUsers.Tables[0];
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

        private string SortBy(string query)
        {
            string Role, OrderBy = string.Empty;

            switch (metroComboBox2.Text)
            {
                case "Администратор": Role = "A"; break;
                case "Бегун": Role = "R"; break;
                case "Координатор": Role = "C"; break;
                default: Role = string.Empty; break;
            }

            switch (metroComboBox1.Text)
            {
                case "Фамилии": OrderBy = "LastName"; break;
                case "Имени": OrderBy = "FirstName"; break;
                default: OrderBy = "RoleId"; break;
            }

            wSRDataSetUsers.Clear();

            if (Role != string.Empty)
            {
                query = "SELECT FirstName, LastName, Email, RoleID FROM Users WHERE RoleId ='" + Role + "' ORDER BY '" + OrderBy + "'";
            }
            else
                query = "SELECT FirstName, LastName, Email, RoleID FROM Users ORDER BY '" + OrderBy + "'";

            return query;
         }

        private void SearchOnEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    metroComboBox2.Enabled = false;
                    metroComboBox1.Enabled = false;
                    e.SuppressKeyPress = true;
                    query = "SELECT * FROM Users WHERE Email LIKE '" + metroTextBox1.Text + "%'";
                    UsersLoad(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void MetroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                Сonnection.EditMail = metroGrid1.CurrentRow.Cells[2].Value.ToString();
                con.Open();
                if (Сonnection.Mail != Сonnection.EditMail)
                {
                    try
                    {
                        if (Сonnection.Mail != "anotherinvocation@gmail.com")
                        {
                            if (metroGrid1.CurrentRow.Cells[3].Value.ToString() == "O")
                            {
                                MessageBox.Show("Недостаточно привелегий для редактирования информации Главного Администратора",
                                    "WSR: Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                if (metroGrid1.CurrentRow.Cells[3].Value.ToString() == "A")
                                {
                                    MessageBox.Show("Недостаточно привелегий для редактирования информации Администратора "
                                        + metroGrid1.CurrentRow.Cells[0].Value.ToString(), "WSR: Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    aUsersEdit UsersEditForm = new aUsersEdit();
                                    UsersEditForm.Show();
                                    Hide();
                                }
                            }
                        }
                        else
                        {
                            aUsersEdit UsersEditForm = new aUsersEdit();
                            UsersEditForm.Show();
                            Hide();
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
                else
                {
                    MessageBox.Show("Это Вы :)", "Нам кажется, что..",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    con.Close();
            }
        }

        private void MetroComboboxes_ValueChange(object sender, EventArgs e)
        {
            UsersLoad(SortBy(query));
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            aUsersAdd UsersAddForm = new aUsersAdd();
            UsersAddForm.Show();
            Hide();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            AdminForm AdminMenu = new AdminForm();
            AdminMenu.Show();
            Hide();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Form1 MainForm = new Form1();
            MainForm.Show();
            Hide();
        }

        private void PictureBox3_Click(object sender, EventArgs e) // Обновление таблицы
        {
            metroComboBox2.Enabled = true;
            metroComboBox1.Enabled = true;
            metroComboBox2.SelectedIndex = 0;
            metroComboBox1.SelectedIndex = 0;
            metroTextBox1.Text = string.Empty;
            UsersLoad("SELECT FirstName, LastName, Email, RoleID FROM Users");
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
