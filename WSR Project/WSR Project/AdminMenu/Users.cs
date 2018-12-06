using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSRProject
{
    public partial class aUsers : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = Сonnection.AzureConnection();
        bool subscribedEvent = true;

        public aUsers()
        {
            InitializeComponent();
            timer1.Start();
            UsersLoadAsync(SortBy());
            FormClosing += new FormClosingEventHandler(AppClose.GoodBye);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            var counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }

        private string UsersCount()
        {
            con.Open();
            var usersCount = new SqlCommand("SELECT COUNT(*) FROM Users", con);
            string count = usersCount.ExecuteScalar().ToString();
            con.Close();
            return count;
        }

        private async void UsersLoadAsync(string query) // Это асинхронный метод, который сортирует и загружает пользователей
        {
            metroGrid1.DataSource = null;
            await Task.Factory.StartNew(() =>
            {
                con.Open();
                var ad = new SqlDataAdapter(query, con); 
                ad.Fill(wSRDataSetUsers, "Users"); 
                con.Close();
            });

            metroGrid1.DataSource = usersBindingSource;
            LoaderPictureBox.Visible = false; 
            LoaderPictureBox.Enabled = false;
            metroLabel3.Text = UsersCount();
            if (!subscribedEvent)
            {                   
                metroComboBox1.TextChanged += new EventHandler(MetroComboboxes_ValueChange);
                metroComboBox2.TextChanged += new EventHandler(MetroComboboxes_ValueChange);
                subscribedEvent = true; 
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
                case "Роли": OrderBy = "RoleId"; break;
                default: OrderBy = "FirstName"; break;
            }

            switch (Role)
            {
                case "":
                    SortQuery = "SELECT FirstName, LastName, Email, RoleID FROM Users ";
                    if (metroTextBox1.Text != string.Empty) SortQuery += "WHERE Email LIKE '" + metroTextBox1.Text + "%' ";
                    SortQuery += "ORDER BY '" + OrderBy + "'";
                    break;

                default:
                    SortQuery = "SELECT FirstName, LastName, Email, RoleID FROM Users WHERE RoleId ='" + Role + "' ";
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
                        LoaderPictureBox.Visible = true;
                        LoaderPictureBox.Enabled = true;
                        e.SuppressKeyPress = true;
                        UsersLoadAsync(SortBy());
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
                                    var UsersEditForm = new aUsersEdit
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
                            var UsersEditForm = new aUsersEdit
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
            LoaderPictureBox.Visible = true;
            LoaderPictureBox.Enabled = true;
            UsersLoadAsync(SortBy());
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            var UsersAddForm = new aUsersAdd
            {
                Location = Location
            };
            UsersAddForm.Show();
            Hide();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            var AdminMenu = new AdminForm
            {
                Location = Location
            };
            AdminMenu.Show();
            Hide();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            var MainForm = new Form1
            {
                Location = Location
            };
            MainForm.Show();
            Hide();
        }

        private void PictureBox3_Click(object sender, EventArgs e) // Обновление таблицы
        {
            if (subscribedEvent) // Проверка, подписано ли событие 
            {
                metroComboBox1.TextChanged -= new EventHandler(MetroComboboxes_ValueChange); // Если да, отписываем
                metroComboBox2.TextChanged -= new EventHandler(MetroComboboxes_ValueChange); // И у этого тоже
                subscribedEvent = false; 
            }
            LoaderPictureBox.Visible = true;
            LoaderPictureBox.Enabled = true;
            metroTextBox1.Text = "";
            metroComboBox1.Text = "Имени"; // Обновляем информацию элемента, для которого произведена отписка
            metroComboBox2.Text = "(Все роли)"; // До начальных значений сортировки
            UsersLoadAsync(SortBy());
        }

    }

}
