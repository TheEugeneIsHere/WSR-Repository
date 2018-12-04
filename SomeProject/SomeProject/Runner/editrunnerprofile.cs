using System;
using System.Data;
using System.Data.SqlClient;
namespace SomeProject
{
    public partial class editrunnerprofile : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = Сonnection.AzureConnection();
        private void timer1_Tick(object sender, EventArgs e)
        {
            Сonnection counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }


        public editrunnerprofile()
        {
            Сonnection counter = new Сonnection();
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Start();
            metroLabel12.Text = counter.getMail();
            metroTextBox2.Text = counter.getName();
            metroTextBox3.Text = counter.getLname();
            getgender();
            metroComboBox1.Text = gender;
            metroDateTime1.Value = ishdate;
            metroComboBox2.Text = contry;
        }

        string gender;
        string contry;
        DateTime ishdate;
       private void getgender()
        {
            Сonnection counter = new Сonnection();
            con.Open();
            string strSQL;
            SqlCommand command = con.CreateCommand();
            strSQL = ("SELECt @Gender=Gender,@DateOfBirth=DateOfBirth,@CountryCode=CountryCode FROM Runner WHERE email=@email");
            SqlParameter Gender,date,country;
            command.CommandText = strSQL;
            Gender = command.Parameters.Add("@Gender", SqlDbType.VarChar, 20);
            Gender.Direction = ParameterDirection.Output;
            date = command.Parameters.Add("@DateOfBirth", SqlDbType.DateTime, 20);
            date.Direction = ParameterDirection.Output;
            country = command.Parameters.Add("@CountryCode", SqlDbType.VarChar, 20);
            country.Direction = ParameterDirection.Output;
            command.Parameters.AddWithValue("@email", counter.getMail());
            command.ExecuteNonQuery();
            gender = Convert.ToString(Gender.Value);
            contry = Convert.ToString(country.Value);
            ishdate = Convert.ToDateTime(date.Value);
            con.Close();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            RunnerForm run = new RunnerForm();
            run.Visible = true;
        }

        private void editrunnerprofile_Load(object sender, EventArgs e)
        {

        }
        
        /*
update Users set Firstname='',LastName='';
update Runner set DateOfBirth='',CountryCode='',Gender='';
если пароль не пустой то
в юзеры+=Password=''; иначе точка с запятой и скопачка ну и вагина, куда же без нее
и капельку масла а то задирет
добавить иконки типа штучку поменяли справа от контрола, по крайней мере попробовать, красота наше все
*/

    }
}
