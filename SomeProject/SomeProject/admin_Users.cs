﻿using System;
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
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            SqlCommand usersCount = new SqlCommand("SELECT COUNT(*) FROM Users", con);
            metroLabel3.Text = usersCount.ExecuteScalar().ToString();
            ad.Fill(wSRDataSetUsers, "Users");
            ad.Dispose();
            con.Close();

            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            metroLabel4.Text = connection.timeremaining.Days + " дней " + connection.timeremaining.Hours +
            " часов и " + connection.timeremaining.Minutes + " минут до сдачи курсового";
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
            metroComboBox2.SelectedIndex = 0;
            metroComboBox1.SelectedIndex = 0;
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
            //using (var connection = new SqlConnection(@"Server=tcp:wsrcurse.database.windows.net,1433;Initial Catalog=WSR;" +
            //    "Persist Security Info=False;User ID=TheEugene;Password=TimCookIsGay7.;" +
            //    "MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            //{
            //    connection.Open();
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            ad.SelectCommand.CommandText = query;
            ad.Fill(wSRDataSetUsers, "Users");
            metroGrid1.DataSource = wSRDataSetUsers.Tables[0];
            
            //    connection.Close();
                
            //}
        }

        private void metroComboboxes_ValueChange(object sender, EventArgs e)
        {
            UsersLoad(SortBy(query));
        }
        private void metroComboBox2_TextChanged(object sender, EventArgs e)
        {
            //UsersLoad(SortBy(query));
            //wSRDataSetUsers.Clear();
            //string Role = "";
            //switch (metroComboBox2.Text)
            //{
            //    case "Администратор":
            //        Role = "A";
            //        break;
            //    case "Бегун":
            //        Role = "R";
            //        break;
            //    case "Координатор":
            //        Role = "C";
            //        break;
            //    default:
            //        Role = "";
            //        break;
            //}

            //if (Role == "")
            //{
            //    query = "SELECT FirstName,LastName,Email, RoleID FROM Users";
            //}
            //else
            //    query = "SELECT FirstName,LastName,Email, RoleID FROM Users WHERE RoleID='" + Role + "'";
            //UsersLoad(query);
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
  
        private void metroComboBox1_TextChanged(object sender, EventArgs e)
        {
            //UsersLoad(SortBy(query));
            //string sort = string.Empty;
            //switch (metroComboBox1.Text)
            //{
            //    case "Фамилии":
            //        sort = "LastName";
            //        break;
            //    case "Имени":
            //        sort = "FirstName";
            //        break;
            //    default:
            //        sort = "RoleId";
            //        break;
            //}

            //wSRDataSetUsers.Clear();

            //if (sort == "")
            //{
            //    query = "SELECT FirstName, LastName, Email, RoleId FROM Users";
            //}
            //else
            //    query = "SELECT FirstName, LastName, Email, RoleId FROM Users ORDER BY '" + sort + "';";
            //UsersLoad(query);
        }
    }
}
