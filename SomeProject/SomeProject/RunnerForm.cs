using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeProject
{
    public partial class RunnerForm : MetroFramework.Forms.MetroForm
    {
        public RunnerForm()
        {
            InitializeComponent();
            this.Text = "MARATHON IS";
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
            // chtoto();
            // metroLabel2.Text = "Добро пожаловать, " + fname + " " + lname;
            metroLabel2.Text = "Меню бегуна";
        }
        DateTime voteTime = new DateTime(2018, 11, 20, 8, 20, 0);
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = voteTime - DateTime.Now;
            metroLabel1.Text = timeremaining.Days + " дней " + timeremaining.Hours + " часов и " + timeremaining.Minutes + " минут до сдачи курсового";
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            regmar reg = new regmar();
            this.Hide();
            reg.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Visible = true;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            moirez moi = new moirez();
            this.Hide();
            moi.ShowDialog();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            this.Hide();
            sponsor spons = new sponsor();
            spons.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            this.Hide();
            editrunnerprofile edit = new editrunnerprofile();
            edit.ShowDialog();
        }
        private string fname;
        private string lname;
        /*private void chtoto()
        {
            SqlConnection con = connection.AzureConnection();
            con.Open();
            var command = new SqlCommand("SELECt @FirstName=FirstName,@LastName=LastName FROM Users WHERE email=@email and password=@password", con);
            SqlParameter FirstName, LastName;
            FirstName = command.Parameters.Add("FirstName", SqlDbType.VarChar, 20);
            FirstName.Direction = ParameterDirection.Output;
            LastName = command.Parameters.Add("LastName", SqlDbType.VarChar, 20);
            LastName.Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();
            MessageBox.Show(Convert.ToString(FirstName));
            fname = Convert.ToString(FirstName);
            lname = Convert.ToString(LastName);
        }*/
    }
}
