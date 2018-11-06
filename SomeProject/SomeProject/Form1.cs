using System;

using System.Windows.Forms;
using System.Data.SqlClient;

namespace SomeProject
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
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
        Form1 f1;
        private void metroTile1_Click(object sender, EventArgs e)
        {
          
            ask ask = new ask();
            this.Visible = false;
            ask.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            AdminForm admOneLove = new AdminForm();
            admOneLove.Show();
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

        private void metroTile8_Click(object sender, EventArgs e)
        {
            // Создание открытого подключения
            using (SqlConnection AzureSS = new SqlConnection())
            {
                // Это строка подключения к облачной БД на серверах Azure
                // Всё должно работать, но так как я залупень в том, что связано с SQL в Visual Studio
                // Решил не мучаться и тупо оставить остальное на тебя
                // Подключай короче, попробуй инфу вытянуть, всё должно работать
                // Импортированы все таблицы, есть все ключи
                AzureSS.ConnectionString = @"Server=tcp:wsrcurse.database.windows.net,1433;Initial Catalog=WSR;" +
                    "Persist Security Info=False;User ID=TheEugene;Password=TimCookIsGay7.;" +
                    "MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            }
        }
    }
}
