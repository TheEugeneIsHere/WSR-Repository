﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SomeProject
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {

        public Login()
        {
            InitializeComponent();
            this.Text = "MARATHON IS";
            timer1.Tick += TimerTick;
            timer1.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            Сonnection counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Hide();
            Сonnection.Mail = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Hide();
        }

        enum Role { Failed, R, C, A }

        private void metroButton1_Click(object sender, EventArgs e)
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
                    if ((string)dataReader["Roleid"] == "R")
                    {
                        role = Role.R;

                    }
                    if ((string)dataReader["Roleid"] == "A" || (string)dataReader["Roleid"] == "O")
                    {
                        role = Role.A;
                    }
                    if ((string)dataReader["Roleid"] == "C")
                    {
                        role = Role.C;
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
                    // connection.mail = metroTextBox1.Text;
                    Сonnection.Password = metroTextBox2.Text;
                    /* Из-за этих строк (Их расположения в IF роль = бегун у меня не работает приветствие
                       Я особо не вникал, но как по мне без разницы бегун или нет, всё равно надо пихать в connection.mail
                       Поэтому я Password здесь оставлю, ашто он не нужен если адмэн как по мне
                       А connection.mail присвою в любом случае
                       Если что-то из этого критично - пиши, намутим по-другому
                       P.S. Я минут 40 всматривался в твой и свой код, не понимая что не так, пока не заметил что connection.mail
                       ..находится в блоке If Runner ...... */
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
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = "leila.azedeva@mskills.com";
            metroTextBox2.Text = "MvTQ3itX";
            login(); // Не за что ага
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
            PasswordRecover password = new PasswordRecover();
            password.ShowDialog();
        }
        /*конец временного мусора*/
    }
}
