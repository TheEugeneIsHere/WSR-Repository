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
            this.Hide();
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = connection.voteTime - DateTime.Now;
            metroLabel3.Text = timeremaining.Days + " дней " + timeremaining.Hours +
            " часов и " + timeremaining.Minutes + " минут до Нового Года";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            admin_CharityAdd charityFormAdd = new admin_CharityAdd();
            charityFormAdd.Show();
            this.Hide();
            this.Dispose();
        }

        private void CharityLoad()
        {
            try
            {
                con.Open();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT CharityName, CharityDescription, CharityLogo FROM Charity", con);
                metroGrid1.Columns[0].DefaultCellStyle.NullValue = (System.Drawing.Image)Properties.Resources.tile_Blago;
                ad.Fill(wSRDataSetCharity, "Charity");
                //metroGrid1.DataSource = wSRDataSetCharity.Tables[0];
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
