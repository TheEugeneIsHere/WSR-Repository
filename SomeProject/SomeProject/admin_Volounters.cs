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
    public partial class admin_Volounters : MetroFramework.Forms.MetroForm
    {
        private static string query = "SELECT FirstName, LastName, CountryCode, Gender FROM Volunteer";
        public admin_Volounters()
        {
            InitializeComponent();
            VolountersLoad(query);
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
            metroLabel3.Text = "Сделай меня";
        }
        DateTime voteTime = new DateTime(2018, 11, 20, 8, 20, 0);

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = voteTime - DateTime.Now;
            metroLabel4.Text = timeremaining.Days + " дней " + timeremaining.Hours + " часов и " + timeremaining.Minutes + " минут до сдачи курсового";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminForm AdminForm = new AdminForm();
            AdminForm.Show();
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            admin_VolountersAdd VolountersAddForm = new admin_VolountersAdd();
            VolountersAddForm.Show();
            this.Close();
        }

        private void VolountersLoad(string query)
        {
            using (var connection = new SqlConnection(@"Server=tcp:wsrcurse.database.windows.net,1433;Initial Catalog=WSR;" +
                "Persist Security Info=False;User ID=TheEugene;Password=TimCookIsGay7.;" +
                "MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter ad = new SqlDataAdapter(query, connection);
                    ad.Fill(wSRDataSetVolounters, "Volunteer");
                    metroGrid1.DataSource = wSRDataSetVolounters.Tables[0];
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }

        }

        private void metroComboBox1_TextChanged(object sender, EventArgs e)
        {
            string sort = string.Empty;
            switch (metroComboBox1.Text)
            {
                case "Фамилии":
                    sort = "LastName";
                    break;
                case "Полу":
                    sort = "Gender";
                    break;
                case "Стране":
                    sort = "CountryCode";
                    break;
                default:
                    sort = "FirstName";
                    break;
            }

            wSRDataSetVolounters.Clear();

            if (sort == "")
            {
                query = "SELECT FirstName, LastName, CountryCode, Gender FROM Volunteer";
            }
            else
                query = "SELECT FirstName, LastName, CountryCode, Gender FROM Volunteer ORDER BY '" + sort + "';";

            VolountersLoad(query);
        }
    }
}
