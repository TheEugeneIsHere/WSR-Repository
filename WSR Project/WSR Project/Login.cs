using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WSRProject
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {

        public Login()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            var counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            var MainForm = new Form1();
            MainForm.Show();
            Hide();
            Сonnection.Mail = "";
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            var MainForm = new Form1();
            MainForm.Show();
            Hide();
        }

        enum Role { Failed, R, C, A }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            login();
        }

        static Role GetRole(string login, string password)
        {
            Role role = Role.Failed;
            SqlConnection con = Сonnection.AzureConnection();
            con.Open();
            var command = new SqlCommand("SELECT RoleId FROM Users WHERE email=@email and password=@password", con);
            command.Parameters.AddWithValue("@email", login);
            command.Parameters.AddWithValue("@password", password);

            using (var dataReader = command.ExecuteReader())
            {
                if (dataReader.Read())
                {
                    switch ((string)dataReader["RoleId"])
                    {
                        case "R": role = Role.R; break;
                        case "A": role = Role.A; break;
                        case "C": role = Role.C; break;
                        default: role = Role.Failed; break;
                    }
                }
            }
            con.Close();
            return role;
        }

        private void login()
        {
            Role role = GetRole(metroTextBox1.Text, metroTextBox2.Text);
            if (role == Role.Failed)
            {
                MessageBox.Show("Неверный логин или пароль", MessageBoxIcon.Error.ToString(), MessageBoxButtons.OK);
            }
            else
            {
                Сonnection.Mail = metroTextBox1.Text;
                if (role == Role.A)
                {
                    var AdminMenu = new AdminForm // Запилил открытие this формы, где base форма, интим вроде
                    {
                        Location = Location
                    };
                    AdminMenu.Show();
                    Hide();
                }
                else if (role == Role.C)
                {
                    var form = new CoordinatorForm();
                    form.Show();
                    Hide();
                }
                else if (role == Role.R)
                {
                    Сonnection.Password = metroTextBox2.Text;
                    var form = new RunnerForm();
                    form.Show();
                    Hide();
                }
            }
        }

        /*временный мусор*/
        private void metroButton3_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = "a.adkin@dayrep.net";
            metroTextBox2.Text = "1234";
            login();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = "leila.azedeva@mskills.com";
            metroTextBox2.Text = "MvTQ3itX";
            login();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void ForgetLabel_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var password = new PasswordRecover();
            password.ShowDialog();
        }
        /*конец временного мусора*/
    }
}
