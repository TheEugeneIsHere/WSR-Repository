using System;

namespace SomeProject
{
    public partial class editrunnerprofile : MetroFramework.Forms.MetroForm
    {
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
в юзеры+=Password='';
*/

    }
}
