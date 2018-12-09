using System;
using System.Data.SqlClient;
using System.Data;

namespace WSRProject
{
    public partial class RunnerForm : MetroFramework.Forms.MetroForm
    {
        
        public RunnerForm()
        {
            InitializeComponent();
            timer1.Start();
            Greting();
            metroLabel2.Text = "Добро пожаловать, " + fname + " " + lname;
            Сonnection.Fname = fname;
            Сonnection.Lname = lname;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            var counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }

        private void MetroTile6_Click(object sender, EventArgs e)
        {
            var log = new Login();
            log.Show();
            Hide();
        }

        private void MetroTile2_Click(object sender, EventArgs e)
        {
            var reg = new MarathonReg
            {
                Location = Location
            };
            reg.Show();
            Hide();
          
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            var log = new Login
            {
                Visible = true
            };
            Hide();
        }

        private void MetroTile1_Click(object sender, EventArgs e)
        {
            var ResultsForm = new RunnerResults();
            ResultsForm.ShowDialog();
            Hide();
        }

        private void MetroTile3_Click(object sender, EventArgs e)
        {
            var EditForm = new EditProfile()
            {
                Location = Location
            };
            EditForm.Show();
            Hide();
        }

        private string fname;
        private string lname;

        private void Greting()
        {
            SqlConnection con = Сonnection.AzureConnection();
            con.Open();
            string  strSQL;
            strSQL=("SELECt @FirstName=FirstName,@LastName=LastName FROM Users WHERE email=@email and password=@password");          
            SqlCommand command = con.CreateCommand();
            command.CommandText = strSQL;
            SqlParameter FirstName, LastName;
            FirstName = command.Parameters.Add("@FirstName", SqlDbType.VarChar, 20);
            FirstName.Direction = ParameterDirection.Output;
            LastName = command.Parameters.Add("@LastName", SqlDbType.VarChar, 20);
            LastName.Direction = ParameterDirection.Output;
            command.Parameters.AddWithValue("@email",Сonnection.Mail);
            command.Parameters.AddWithValue("@password", Сonnection.Password);
            command.ExecuteNonQuery();
            fname = Convert.ToString(FirstName.Value);
            lname = Convert.ToString(LastName.Value);
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {

        }
    }
}
