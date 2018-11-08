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
    public partial class admin_Volunteer : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = connection.AzureConnection();
        private static string query = "SELECT FirstName, LastName, CountryCode, Gender FROM Volunteer";

        public admin_Volunteer()
        {
            InitializeComponent();
            con.Open();
            VolountersLoad(query);
            con.Close();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //TimeSpan timeremaining = connection.voteTime - DateTime.Now;
            metroLabel4.Text = connection.timeremaining.Days + " дней " + connection.timeremaining.Hours +
                " часов и " + connection.timeremaining.Minutes + " минут до сдачи курсового";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminForm AdminForm = new AdminForm();
            AdminForm.Show();
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            admin_VolunteerAdd VolountersAddForm = new admin_VolunteerAdd();
            VolountersAddForm.Show();
            this.Close();
        }

        private void VolountersLoad(string query)
        {
            //using (var connection = new SqlConnection(@"Server=tcp:wsrcurse.database.windows.net,1433;Initial Catalog=WSR;" +
            //    "Persist Security Info=False;User ID=TheEugene;Password=TimCookIsGay7.;" +
            //    "MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            //{
                try
                {
                    SqlDataAdapter ad = new SqlDataAdapter(query, con);
                    SqlCommand usersCount = new SqlCommand("SELECT COUNT(*) FROM Volunteer",con);
                    metroLabel3.Text = usersCount.ExecuteScalar().ToString();
                    ad.Fill(wSRDataSetVolunteer, "Volunteer");
                    metroGrid1.DataSource = wSRDataSetVolunteer.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            //}

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

            wSRDataSetVolunteer.Clear();

            if (sort == "")
            {
                query = "SELECT FirstName, LastName, CountryCode, Gender FROM Volunteer";
            }
            else
                query = "SELECT FirstName, LastName, CountryCode, Gender FROM Volunteer ORDER BY '" + sort + "';";

            con.Open();
            VolountersLoad(query);
            con.Close();
        }
    }
}
