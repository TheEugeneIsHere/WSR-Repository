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
                    var form = new RunnerForm();
                    this.Hide();
                    form.ShowDialog();
                    
                }
            }
        }
    }
}
