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
        SqlConnection con = connection.AzureConnection();

        public admin_Users()
        {
            InitializeComponent();
            UsersCount();
            UsersLoad(query);
            timer1.Tick += timer1_Tick;
            timer1.Start();
            this.Cursor = Cursors.Default;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = connection.voteTime - DateTime.Now;
            metroLabel4.Text = timeremaining.Days + " дней " + timeremaining.Hours +
            " часов и " + timeremaining.Minutes + " минут до Нового Года";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminForm admForm = new AdminForm();
            admForm.Show();
            this.Hide();
            this.Dispose();
        }

        private void pictureBox3_Click(object sender, EventArgs e) // Обновление таблицы
        {
            metroComboBox2.SelectedIndex = 0;
            metroComboBox1.SelectedIndex= 0;
            metroTextBox1.Text = string.Empty;
            metroComboBox2.Enabled = true;
            metroComboBox1.Enabled = true;
            UsersLoad("SELECT FirstName, LastName, Email, RoleID FROM Users");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            admin_UsersAdd userAddForm = new admin_UsersAdd();
            userAddForm.Show();
            this.Hide();
            this.Dispose();
        }
        
        private void UsersLoad(string query)
        {
            try
            {
                con.Open();
                wSRDataSetUsers.Clear();
                SqlDataAdapter ad = new SqlDataAdapter(query, con);
                ad.Fill(wSRDataSetUsers, "Users");
                metroGrid1.DataSource = wSRDataSetUsers.Tables[0];
                con.Close();
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

        private void metroComboboxes_ValueChange(object sender, EventArgs e)
        {
            UsersLoad(SortBy(query));
        }

        private string SortBy(string query)
        {
            string Role, OrderBy = string.Empty;

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
                    Role = string.Empty;
                    break;
            }

            switch (metroComboBox1.Text)
            {
                case "Фамилии":
                    OrderBy = "LastName";
                    break;
                case "Имени":
                    OrderBy = "FirstName";
                    break;
                default:
                    OrderBy = "RoleId";
                    break;
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
  

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >=0)
            {
                
                connection.editMail = metroGrid1.CurrentRow.Cells[2].Value.ToString();
                con.Open();
                try
                {
                    admin_UsersEdit usersEdit = new admin_UsersEdit();
                    usersEdit.Show();
                    this.Hide();
                    this.Dispose();
                    SqlCommand userEdit = new SqlCommand("SELECT * FROM Users WHERE Email ='" + connection.editMail + "'", con);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Hide();
            this.Dispose();
        }
    }
}
