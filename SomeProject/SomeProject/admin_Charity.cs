using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeProject
{
    public partial class admin_Charity : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = connection.AzureConnection();

        public admin_Charity()
        {
            InitializeComponent();
            CharityLoad();
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminForm adminMenu = new AdminForm();
            adminMenu.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = connection.voteTime - DateTime.Now;
            metroLabel3.Text = timeremaining.Days + " дней " + timeremaining.Hours +
            " часов и " + timeremaining.Minutes + " минут до сдачи курсового";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            admin_CharityAdd clarityFormAdd = new admin_CharityAdd();
            clarityFormAdd.Show();
            this.Hide();
        }

        private void CharityLoad()
        {
            //using (var connection = new SqlConnection(@"Server=tcp:wsrcurse.database.windows.net,1433;Initial Catalog=WSR;" +
            //    "Persist Security Info=False;User ID=TheEugene;Password=TimCookIsGay7.;" +
            //    "MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            //{

            //string query = "SELECT CharityLogo, CharityName, CharityDescription FROM Charity"; // Строка запроса
            //SqlCommand command = new SqlCommand(query, connection); // Создан объект для выполнения запроса к БД
            //SqlDataReader reader = command.ExecuteReader(); // Объект читающий данные из таблицы БД
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter("SELECT CharityLogo, CharityName, CharityDescription FROM Charity", con);
            ad.Fill(wSRDataSetCharity, "Charity");
            metroGrid1.DataSource = wSRDataSetCharity.Tables[0];
            con.Close();
            // var logos = new DataGridViewImageColumn();
            // logos.Name = "Логотип";
            // wSRDataSet.Charity.Columns.Add(logos);

            //List<string[]> data = new List<string[]>();
            //while (reader.Read())
            //{
            //    data.Add(new string[3]);


            //    data[data.Count - 1][0] = reader[0].ToString();
            //    data[data.Count - 1][1] = reader[1].ToString();
            //    data[data.Count - 1][2] = reader[2].ToString();
            //}
            //// Каким-то макаром нужно закинуть сюда ещё логотипы
            //reader.Close();

            //foreach (string[] s in data)
            //    wSRDataSet.Charity.Rows.Add(s);
            //}
        }
    }
}
