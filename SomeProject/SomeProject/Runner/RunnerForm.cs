using System;
using System.Data.SqlClient;
using System.Data;

namespace SomeProject
{
    public partial class RunnerForm : MetroFramework.Forms.MetroForm
    {
        public RunnerForm()
        {
            InitializeComponent();
            this.Text = "MARATHON IS";
            timer1.Tick += timer1_Tick;
            timer1.Start();
            greting();
            metroLabel2.Text = "Добро пожаловать, " + fname + " " + lname;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Сonnection counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
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



        private void metroTile3_Click(object sender, EventArgs e)
        {
            this.Hide();
            editrunnerprofile edit = new editrunnerprofile();
            edit.ShowDialog();
        }
        private string fname;
        private string lname;
        private void greting()
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
    }
}
