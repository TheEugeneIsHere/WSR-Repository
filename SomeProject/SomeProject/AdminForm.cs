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
                SqlCommand login = new SqlCommand("SELECT FirstName FROM Users WHERE RoleId = 'A' AND Email = '" + connection.mail + "'", con);
                loginLabel1.Text += login.ExecuteScalar().ToString();
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
            metroLabel1.Text = timeremaining.Days + " дней " + timeremaining.Hours +
            " часов и " + timeremaining.Minutes + " минут до Нового Года";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
            this.Dispose();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            admin_Charity charityForm = new admin_Charity();
            charityForm.Show();
            this.Hide();
            this.Dispose();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            admin_Volunteer admin_Volounters = new admin_Volunteer();
            admin_Volounters.Show();
            this.Hide();
            this.Dispose();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            admin_Users UsersForm = new admin_Users();
            UsersForm.Show();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Hide();
            this.Dispose();
        }
    }
}
