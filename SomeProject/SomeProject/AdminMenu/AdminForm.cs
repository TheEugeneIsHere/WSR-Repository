using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SomeProject
{
    public partial class AdminForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = Сonnection.AzureConnection();

        public AdminForm()
        {
            InitializeComponent();
            GetLogin();
            timer1.Start();
        }

        private void GetLogin()
        {
            try
            {
                con.Open();
                SqlCommand login = new SqlCommand("SELECT FirstName FROM Users WHERE Email = '" + Сonnection.Mail + "'", con);
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

        private void TimerTick(object sender, EventArgs e)
        {
            Сonnection counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }

        private void MetroTile1_Click(object sender, EventArgs e)
        {
            aUsers UsersForm = new aUsers
            {
                Location = Location
            };
            UsersForm.Show();
            Hide();
        }

        private void MetroTile2_Click(object sender, EventArgs e)
        {
            aVolunteer VolunteerForm = new aVolunteer
            {
                Location = Location
            };
            VolunteerForm.Show();
            Hide();
        }

        private void MetroTile3_Click(object sender, EventArgs e)
        {
            aCharity CharityForm = new aCharity
            {
                Location = Location
            };
            CharityForm.Show();
            Hide();
        }

        private void LogoutPic_Click(object sender, EventArgs e)
        {
            Form1 MainForm = new Form1
            {
                Location = Location
            };
            MainForm.Show();
            Hide();
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
