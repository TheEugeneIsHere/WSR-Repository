using System;
using System.Data.SqlClient;

namespace SomeProject
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = Сonnection.AzureConnection();

        public Form1()
        {
            InitializeComponent();
            Elements(IsConnectedToInternet()); // Проверка подключения к БД
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
            //metroTile2.Enabled = internet;
            metroTile3.Enabled = internet;
            metroTile4.Enabled = internet;
            metroTile5.Enabled = internet;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = Сonnection.GetTime - DateTime.Now;
            timerLabel.Text = timeremaining.Days + " дней " + timeremaining.Hours +
            " часов и " + timeremaining.Minutes + " минут до сдачи курсового";
        }

        private void MetroTile1_Click(object sender, EventArgs e)
        {
            ask ask = new ask();
            ask.ShowDialog();
            Hide();
        }

        private void MetroTile4_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void MetroTile6_Click(object sender, EventArgs e)
        {
            RunnerForm run = new RunnerForm();
            run.Show();
            Hide();
        }

        private void MetroTile7_Click(object sender, EventArgs e)
        {
            BMIcalc bmiForm = new BMIcalc();
            bmiForm.Show();
            Hide();
        }

        private void MetroTile3_Click(object sender, EventArgs e)
        {
            InfoForm InfoMenu = new InfoForm();
            InfoMenu.Show();
            Hide();
        }

    }
}
