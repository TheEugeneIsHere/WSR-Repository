using System;
using System.Data;
using System.Data.SqlClient;

namespace SomeProject
{
    public partial class EditProfile : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = Сonnection.AzureConnection();

        string gender;
        string contry;
        DateTime ishdate;

        public EditProfile()
        {
            var counter = new Сonnection();
            InitializeComponent();
            timer1.Start();
            metroLabel12.Text = counter.getMail();
            metroTextBox2.Text = counter.getName();
            metroTextBox3.Text = counter.getLname();
            GetGender();
            metroComboBox1.Text = gender;
            metroDateTime1.Value = ishdate;
            metroComboBox2.Text = contry;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            var counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }

        private void GetGender()
        {
            var counter = new Сonnection();
            con.Open();
            string strSQL;
            var command = con.CreateCommand();
            strSQL = ("SELECT @Gender=Gender,@DateOfBirth=DateOfBirth,@CountryCode=CountryCode FROM Runner WHERE email=@email");
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

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            var run = new RunnerForm
            {
                Visible = true
            };
            Hide();
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
