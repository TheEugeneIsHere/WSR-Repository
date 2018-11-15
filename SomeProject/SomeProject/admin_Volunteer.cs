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
        private static string query = "SELECT FirstName, LastName, CountryCode, Gender FROM Volunteer ORDER BY FirstName";

        public admin_Volunteer()
        {
            InitializeComponent();
            VolunteerLoad(query);
            VolunteerCount();
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = connection.voteTime - DateTime.Now;
            metroLabel4.Text = timeremaining.Days + " дней " + timeremaining.Hours +
            " часов и " + timeremaining.Minutes + " минут до сдачи курсового";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminForm AdminForm = new AdminForm();
            AdminForm.Show();
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            admin_VolunteerAdd VolunteerAddForm = new admin_VolunteerAdd();
            VolunteerAddForm.Show();
            this.Close();
        }

        private void VolunteerCount()
        {
            try
            {
                con.Open();
                SqlCommand usersCount = new SqlCommand("SELECT COUNT(*) FROM Volunteer", con);
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

        private void VolunteerLoad(string query)
        {
            try
            {
                con.Open();
                SqlDataAdapter ad = new SqlDataAdapter(query, con);
                ad.Fill(wSRDataSetVolunteer, "Volunteer");
                metroGrid1.DataSource = wSRDataSetVolunteer.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
            VolunteerLoad("SELECT FirstName, LastName, CountryCode, Gender FROM Volunteer ORDER BY " + sort);
        }
    }
}
