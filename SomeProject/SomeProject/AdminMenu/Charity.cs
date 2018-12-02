using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SomeProject
{
    public partial class aCharity : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = Сonnection.AzureConnection();

        public aCharity()
        {
            InitializeComponent();
            timer1.Start();
            CharityLoad();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = Сonnection.GetTime - DateTime.Now;
            metroLabel3.Text = timeremaining.Days + " дней " + timeremaining.Hours +
            " часов и " + timeremaining.Minutes + " минут до Нового Года";
        }

        private void CharityLoad()
        {
            try
            {
                con.Open();
                metroGrid1.Columns[0].DefaultCellStyle.NullValue = Properties.Resources.tile_Blago;
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

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            aCharityAdd CharityAddForm = new aCharityAdd();
            CharityAddForm.Show();
            Hide();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            AdminForm AdminMenu = new AdminForm();
            AdminMenu.Show();
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
