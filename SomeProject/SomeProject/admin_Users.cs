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
    public partial class admin_Users : MetroFramework.Forms.MetroForm
    {
        private static string query = "SELECT FirstName, LastName, Email, RoleID FROM Users";
        public admin_Users()
        {
            InitializeComponent();
            UsersLoad(query);
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
            Random rnd = new Random();
            // Нада не забыть заменить её на подругзку из БД. Хотя я и так не забуду
            // Но всё равно лучше оставить здесь огромные зеленые буковки
        }
        DateTime voteTime = new DateTime(2018, 11, 20, 8, 20, 0);

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = voteTime - DateTime.Now;
            metroLabel4.Text = timeremaining.Days + " дней " + timeremaining.Hours + " часов и " + timeremaining.Minutes + " минут до сдачи курсового";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminForm admForm = new AdminForm();
            admForm.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e) // Обновление таблицы
        {
            wSRDataSetUsers.Clear();
            UsersLoad(query);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            admin_UsersAdd userAddForm = new admin_UsersAdd();
            userAddForm.Show();
            this.Close();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            admin_UsersEdit UsersEditForm = new admin_UsersEdit();
            UsersEditForm.Show();
            this.Close();
        }

        private void UsersLoad(string query)
        {
            using (var connection = new SqlConnection(@"Server=tcp:wsrcurse.database.windows.net,1433;Initial Catalog=WSR;" +
                "Persist Security Info=False;User ID=TheEugene;Password=TimCookIsGay7.;" +
                "MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                connection.Open();
                SqlDataAdapter ad = new SqlDataAdapter(query, connection);
                ad.Fill(wSRDataSetUsers, "Users");
                metroGrid1.DataSource = wSRDataSetUsers.Tables[0];
                connection.Close();
            }
        }

        private void metroComboBox2_TextChanged(object sender, EventArgs e)
        {
            wSRDataSetUsers.Clear();
            string Role = "";
            switch (metroComboBox2.Text)
            {
                case "Администратор":
                    Role = "A";
                    break;
                case "Бегун":
                    Role = "R";
                    break;
                case "Координатор":
                    Role = "C";
                    break;
                default:
                    Role = "";
                    break;
            }

            if (Role == "")
            {
                query = "SELECT FirstName,LastName,Email, RoleID FROM Users";
            }
            else
                query = "SELECT FirstName,LastName,Email, RoleID FROM Users WHERE RoleID='" + Role + "'";
            UsersLoad(query);
        }

        private void metroComboBox1_TextChanged(object sender, EventArgs e)
        {
            string sort = string.Empty;
            switch (metroComboBox1.Text)
            {
                case "Фамилии":
                    sort = "LastName";
                    break;
                case "Имени":
                    sort = "FirstName";
                    break;
                default:
                    sort = "RoleId";
                    break;
            }

            wSRDataSetUsers.Clear();

            if (sort == "")
            {
                query = "SELECT FirstName, LastName, Email, RoleId FROM Users";
            }
            else
                query = "SELECT FirstName, LastName, Email, RoleId FROM Users ORDER BY '" + sort + "';";

            UsersLoad(query);
        }
    }
}
