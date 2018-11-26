using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeProject
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
            this.Text = "MARATHON IS";

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

        private void metroButton2_Click(object sender, EventArgs e)
        {
            metroTextBox1.Clear();
            metroTextBox2.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
        enum Role { Failed, R, C, A }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            login();
        }
        static Role GetRole(string login, string password)
        {
            Role role = Role.Failed;
            using (var connection = new SqlConnection(@"Server=tcp:wsrcurse.database.windows.net,1433;Initial Catalog=WSR;" +
                "Persist Security Info=False;User ID=TheEugene;Password=TimCookIsGay7.;" +
                "MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                connection.Open();
                var command = new SqlCommand("SELECT RoleId FROM Users WHERE email=@email and password=@password", connection);
                command.Parameters.AddWithValue("@email", login);
                command.Parameters.AddWithValue("@password", password);

                using (var dataReader = command.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        if ((string)dataReader["Roleid"] == "R")
                        {
                            role = Role.R;
                           
                        }
                        if ((string)dataReader["Roleid"] == "A")
                        {
                            role = Role.A;
                        }
                        if ((string)dataReader["Roleid"] == "C")
                        {
                            role = Role.C;
                        }


                    }
                }
                return role;
            }
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
                connection.mail = metroTextBox1.Text;
                if (role == Role.A)
                {
                    var form = new AdminForm();
                    this.Hide();
                    form.ShowDialog();
                    
                }
                else if (role == Role.C)
                {
                    var form = new CoordinatorForm();
                    this.Hide();
                    form.ShowDialog();

                   
                }
                else if (role == Role.R)
                {
                    // connection.mail = metroTextBox1.Text;
                     connection.password = metroTextBox2.Text;
                    // Из-за этих строк (Их расположения в IF роль = бегун у меня не работает приветствие
                    // Я особо не вникал, но как по мне без разницы бегун или нет, всё равно надо пихать в connection.mail
                    // Поэтому я Password здесь оставлю, ашто он не нужен если адмэн как по мне
                    // А connection.mail присвою в любом случае
                    // Если что-то из этого критично - пиши, намутим по-другому
                    // P.S. Я минут 40 всматривался в твой и свой код, не понимая что не так, пока не заметил что connection.mail
                    // ..находится в блоке If Runner ......
                    var form = new RunnerForm();
                    this.Hide();                    
                    form.ShowDialog();
                    
                }
            }
        }

        /*временный мусор*/
        private void metroButton3_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = "a.adkin@dayrep.net";
            metroTextBox2.Text = "jwZh2x@p";
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = "leila.azedeva@mskills.com";
            metroTextBox2.Text = "MvTQ3itX";
            login(); // Не за что ага
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (connection.theme)
            {
                Theme = MetroFramework.MetroThemeStyle.Dark;
                metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroLabel1.Style = MetroFramework.MetroColorStyle.White;
                metroLabel2.Style = MetroFramework.MetroColorStyle.White;
                metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroLabel3.Style = MetroFramework.MetroColorStyle.White;
                metroLabel4.Style = MetroFramework.MetroColorStyle.White;
                metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroTextBox2.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroLabel5.Style = MetroFramework.MetroColorStyle.White;

            }
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

        private void forgetLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordRecover password = new PasswordRecover();
            password.Show();
            this.Hide();
            this.Dispose();
        }
        /*конец временного мусора*/
    }
}
