using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WSRProject
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        
        SqlConnection con = Сonnection.AzureConnection();
        static bool IsConnected = true;

        public Form1()
        {
            InitializeComponent();
            if (IsConnected) Elements(IsConnectedToInternet()); // Проверка подключения к БД
            else Elements(false);
           // new System.Media.SoundPlayer(Properties.Resources.Azaza).Play(); // Ну это так, чисто поорать ахахах
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
                IsConnected = false;
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
            metroTile5.Enabled = internet;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            var counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }

        private void MetroTile1_Click(object sender, EventArgs e) // Хочу стать бегуном
        {
            var ask = new Ask();
            ask.ShowDialog();
            Hide();
        }

        private void MetroTile3_Click(object sender, EventArgs e) // Информация о марафоне
        {
            var InfoMenu = new InfoForm();
            InfoMenu.Show();
            Hide();
        }

        private void MetroTile4_Click(object sender, EventArgs e) // Калькулятор ИМТ
        {
            var bmiForm = new BMIcalc();
            bmiForm.Show();
            Hide();
        }

        private void MetroTile5_Click(object sender, EventArgs e) // Вход в систему
        {
            var log = new Login();
            log.Show();
            Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count > 0) Application.Exit();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            new System.Media.SoundPlayer(Properties.Resources.Azaza).Stop();
        }
    }
}
