using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SomeProject
{
    public partial class aCharity : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = connection.AzureConnection();
        BackgroundWorker bw;

        public aCharity()
        {
            InitializeComponent();
            bw = new BackgroundWorker();
            bw.DoWork += (obj, ea) => CharityLoad();
            bw.RunWorkerAsync();
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = connection.voteTime - DateTime.Now;
            metroLabel3.Text = timeremaining.Days + " дней " + timeremaining.Hours +
            " часов и " + timeremaining.Minutes + " минут до Нового Года";
        }

        private void CharityLoad()
        {
            try
            {
                con.Open();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT CharityName, CharityDescription, CharityLogo FROM Charity", con);
                ad.Fill(wSRDataSetCharity1, "Charity");

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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            aCharityAdd CharityAddForm = new aCharityAdd();
            CharityAddForm.Show();
            this.Hide();
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminForm AdminMenu = new AdminForm();
            AdminMenu.Show();
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
