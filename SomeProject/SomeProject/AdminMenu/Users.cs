using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SomeProject
{
    public partial class aUsers : MetroFramework.Forms.MetroForm
    {
        //private static string query = "SELECT FirstName, LastName, Email, RoleID FROM Users";
        SqlConnection con = Сonnection.AzureConnection();

        public aUsers()
        {
            InitializeComponent();
            metroGrid1.DataSource = null;
            if (!backLoad.IsBusy) backLoad.RunWorkerAsync();
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
                //if (backLoad.IsBusy) metroGrid1.DataSource = null;
                con.Open();
                SqlDataAdapter ad = new SqlDataAdapter(query, con);
                ad.Fill(wSRDataSetUsers, "Users");
                if (backLoad.IsBusy) backLoad.CancelAsync();
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

        private string SortBy()
        {
            string Role, OrderBy, SortQuery = string.Empty;

            wSRDataSetUsers.Tables[0].Clear();
            switch (metroComboBox2.Text)
            {
                case "Администратор": Role = "A"; break;
                case "Бегун": Role = "R"; break;
                case "Координатор": Role = "C"; break;
                default: Role = ""; break;
            }

            switch (metroComboBox1.Text)
            {
                case "Фамилии": OrderBy = "LastName"; break;
                case "Имени": OrderBy = "FirstName"; break;
                default: OrderBy = "RoleId"; break;
            }

            switch (Role)
            {
                case "":
                    SortQuery = "SELECT FirstName, LastName, Email, RoleID FROM Users ";
                    if (metroTextBox1.Text != string.Empty) SortQuery += "WHERE Email LIKE '" + metroTextBox1.Text + "%' ";
                    SortQuery += "ORDER BY '" + OrderBy + "'";
                break;

                default:
                    SortQuery = "SELECT * FROM Users WHERE RoleId ='" + Role + "' ";
                    if (metroTextBox1.Text != string.Empty) SortQuery += "AND Email LIKE '" + metroTextBox1.Text + "%' ";
                    SortQuery += "ORDER BY '" + OrderBy + "'";
                break;
            }

            return SortQuery;
         }

        private void SearchOnEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (metroTextBox1.Text != string.Empty)
                {
                    try
                    {
                        e.SuppressKeyPress = true;
                        UsersLoad(SortBy());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
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
                                    aUsersEdit UsersEditForm = new aUsersEdit
                                    {
                                        Location = Location
                                    };
                                    UsersEditForm.Show();
                                    Hide();
                                }
                            }
                        }
                        else
                        {
                            aUsersEdit UsersEditForm = new aUsersEdit
                            {
                                Location = Location
                            };
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
            UsersLoad(SortBy());
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            aUsersAdd UsersAddForm = new aUsersAdd
            {
                Location = Location
            };
            UsersAddForm.Show();
            Hide();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            AdminForm AdminMenu = new AdminForm
            {
                Location = Location
            };
            AdminMenu.Show();
            Hide();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Form1 MainForm = new Form1
            {
                Location = Location
            };
            MainForm.Show();
            Hide();
        }

        private void PictureBox3_Click(object sender, EventArgs e) // Обновление таблицы
        {
            UsersLoad(SortBy());
            //metroComboBox2.Enabled = true;
            //metroComboBox1.Enabled = true;
            //metroComboBox2.SelectedIndex = 0;
            //metroComboBox1.SelectedIndex = 0;
            //metroTextBox1.Text = string.Empty;
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

        private void BackLoad_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            LoaderPictureBox.Visible = true;
            LoaderPictureBox.Enabled = true;
            UsersCount();
            UsersLoad(SortBy());
        }

        private void BackLoad_Completed(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            //metroGrid1.DataSource = usersBindingSource;
            metroGrid1.DataSource = wSRDataSetUsers.Tables[0];
            LoaderPictureBox.Visible = false;
            LoaderPictureBox.Enabled = false;
        }
    }

}
