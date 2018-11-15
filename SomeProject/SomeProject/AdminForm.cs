using System;
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
    public partial class AdminForm : MetroFramework.Forms.MetroForm
    {
        public AdminForm()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = connection.voteTime - DateTime.Now;
            metroLabel1.Text = timeremaining.Days + " дней " + timeremaining.Hours +
            " часов и " + timeremaining.Minutes + " минут до сдачи курсового";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            admin_Charity charityForm = new admin_Charity();
            charityForm.Show();
            this.Close();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            admin_Volunteer admin_Volounters = new admin_Volunteer();
            admin_Volounters.Show();
            this.Close();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            admin_Users UsersForm = new admin_Users();
            UsersForm.Show();
            this.Close();
        }
    }
}
