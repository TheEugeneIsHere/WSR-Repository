using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SomeProject
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = connection.AzureConnection();

        public Form1()
        {
            InitializeComponent();
            Elements(IsConnectedToInternet()); // Проверка подключения к БД
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private bool IsConnectedToInternet()
        {
            try
            {
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                    return true;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        private void Elements(bool internet)
        {
            metroLabel3.Enabled = !internet;
            metroLabel3.Visible = !internet;
            metroTile1.Enabled = internet;
            metroTile2.Enabled = internet;
            metroTile3.Enabled = internet;
            metroTile4.Enabled = internet;
            metroTile5.Enabled = internet;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = connection.voteTime - DateTime.Now;
            metroLabel1.Text = timeremaining.Days + " дней " + timeremaining.Hours +
            " часов и " + timeremaining.Minutes + " минут до сдачи курсового";
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ask ask = new ask();
            ask.ShowDialog();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ShowDialog();
            this.Hide();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            RunnerForm run = new RunnerForm();
            run.Show();
            this.Hide();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            BMIcalc calculatorForm = new BMIcalc();
            calculatorForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void metroComboBox1_TextChanged(object sender, EventArgs e)
        {
            if (metroComboBox1.Text == "Темная")
            {
                Theme = MetroFramework.MetroThemeStyle.Dark;
                metroComboBox1.Style= MetroFramework.MetroColorStyle.Yellow;
                metroTile1.Style = MetroFramework.MetroColorStyle.Yellow;
                metroTile2.Style = MetroFramework.MetroColorStyle.Yellow;
                metroTile3.Style = MetroFramework.MetroColorStyle.Yellow;
                metroTile5.Style = MetroFramework.MetroColorStyle.Yellow;
                metroTile4.Style = MetroFramework.MetroColorStyle.Yellow;
                metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroLabel1.Style = MetroFramework.MetroColorStyle.White;
                metroLabel2.Style = MetroFramework.MetroColorStyle.White;
                metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
                this.Style = MetroFramework.MetroColorStyle.Yellow;
                connection.theme = true;
                this.Refresh();
            }
            else
                if(metroComboBox1.Text == "Светлая")
            {
                Theme = MetroFramework.MetroThemeStyle.Light;
                metroComboBox1.Style = MetroFramework.MetroColorStyle.Blue;
                metroTile1.Style = MetroFramework.MetroColorStyle.Blue;
                metroTile2.Style = MetroFramework.MetroColorStyle.Blue;
                metroTile3.Style = MetroFramework.MetroColorStyle.Blue;
                metroTile5.Style = MetroFramework.MetroColorStyle.Blue;
                metroTile4.Style = MetroFramework.MetroColorStyle.Blue;
                metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
                metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
                metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
                metroLabel2.Style = MetroFramework.MetroColorStyle.Black;
                metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Light;
                this.Style = MetroFramework.MetroColorStyle.Blue;
                connection.theme = false;
                this.Refresh();
            }
        }
    }
}
