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
    public partial class ask : MetroFramework.Forms.MetroForm
    {
        public ask()
        {
            InitializeComponent();
            this.Text = "MARATHON IS";
            
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();

        }
        DateTime voteTime = new DateTime(2018, 11, 20, 8, 20, 0);

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = voteTime - DateTime.Now;
            metroLabel1.Text = timeremaining.Days + " дней " + timeremaining.Hours + " часов и " + timeremaining.Minutes + " минут до сдачи курсового";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Close();
            f1.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            registration reg = new registration();
            this.Hide();
            reg.ShowDialog();
        }
    }
}
