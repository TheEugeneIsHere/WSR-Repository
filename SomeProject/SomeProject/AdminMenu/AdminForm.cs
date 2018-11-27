using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SomeProject
{
    public partial class AdminForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = connection.AzureConnection();

        public AdminForm()
        {
            InitializeComponent();
            getLogin();
            timer1.Tick += timer1_Tick;
            timer1.Start();

        }

        private void getLogin()
        {
            try
            {
                con.Open();
                SqlCommand login = new SqlCommand("SELECT FirstName FROM Users WHERE Email = '" + connection.mail + "'", con);
                loginLabel.Text += login.ExecuteScalar().ToString();
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
            timerLabel.Text = timeremaining.Days + " дней " + timeremaining.Hours +
            " часов и " + timeremaining.Minutes + " минут до Нового Года";
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            aUsers UsersForm = new aUsers();
            UsersForm.Show();
            this.Hide();
            this.Dispose();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            aVolunteer VolunteerForm = new aVolunteer();
            VolunteerForm.Show();
            this.Hide();
            this.Dispose();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            aCharity CharityForm = new aCharity();
            CharityForm.Show();
            this.Hide();
            this.Dispose();
        }

        private void logoutPic_Click(object sender, EventArgs e)
        {
            Form1 MainForm = new Form1();
            MainForm.Show();
            this.Hide();
            this.Dispose();
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
    }
}
