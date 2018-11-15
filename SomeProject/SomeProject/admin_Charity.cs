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
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = connection.voteTime - DateTime.Now;
            metroLabel3.Text = timeremaining.Days + " дней " + timeremaining.Hours +
            " часов и " + timeremaining.Minutes + " минут до сдачи курсового";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            admin_CharityAdd charityFormAdd = new admin_CharityAdd();
            charityFormAdd.Show();
            this.Hide();
        }

        private void CharityLoad()
        {
            try
            {
                con.Open();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT CharityLogo, CharityName, CharityDescription FROM Charity", con);
                ad.Fill(wSRDataSetCharity, "Charity");
                metroGrid1.DataSource = wSRDataSetCharity.Tables[0];
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
    }
}
