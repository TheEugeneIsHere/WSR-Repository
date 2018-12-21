using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WSRProject
{
#pragma warning disable IDE1006
    public partial class aVolunteer : MetroFramework.Forms.MetroForm
#pragma warning restore IDE1006
    {
        SqlConnection con = Сonnection.AzureConnection();
        private static string query = "SELECT FirstName, LastName, CountryCode, Gender FROM Volunteer ORDER BY FirstName";

        public aVolunteer()
        {
            InitializeComponent();
            VolunteerLoad(query);
            VolunteerCount();
            timer1.Start();
            FormClosing += new FormClosingEventHandler(AppClose.GoodBye);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            var counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }

        private void VolunteerCount()
        {
            try
            {
                con.Open();
                var usersCount = new SqlCommand("SELECT COUNT(*) FROM Volunteer", con);
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
                metroGrid1.DataSource = null;
                con.Open();
                var ad = new SqlDataAdapter(query, con);
                wSRDataSetVolunteer.Tables[0].Clear();
                ad.Fill(wSRDataSetVolunteer, "Volunteer");
                metroGrid1.DataSource = volunteerBindingSource;
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

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            var VolunteerAddForm = new aVolunteerAdd
            {
                Location = Location
            };
            VolunteerAddForm.Show();
            Hide();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            var AdminForm = new AdminForm
            {
                Location = Location
            };
            AdminForm.Show();
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

        private void MetroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sort = string.Empty;
            switch (metroComboBox1.Text)
            {
                case "Фамилии": sort = "LastName"; break;
                case "Полу": sort = "Gender"; break;
                case "Стране": sort = "CountryCode"; break;
                default: sort = "FirstName"; break;
            }

            VolunteerLoad("SELECT FirstName, LastName, CountryCode, Gender FROM Volunteer ORDER BY " + sort);
        }

    }
}
