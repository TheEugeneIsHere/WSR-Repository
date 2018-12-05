using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SomeProject
{
    public partial class MarathonReg : MetroFramework.Forms.MetroForm
    {
        public MarathonReg()
        {
            InitializeComponent();
            timer1.Tick += TimerTick;
            timer1.Start();
        }

        int distance = 0, stoim = 0, vznos = 0, variant = 0, itog = 0;
        ErrorProvider error = new ErrorProvider { BlinkStyle = ErrorBlinkStyle.NeverBlink };
        SqlConnection con = Сonnection.AzureConnection();

        private void TimerTick(object sender, EventArgs e)
        {
            Сonnection counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            RunnerForm run = new RunnerForm
            {
                Visible = true
            };
        }

        private void BunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked == true)
            {
                distance = 42;
                stoim = 145;
                bunifuCheckbox2.Checked = false;
                bunifuCheckbox3.Checked = false;
                itog = vznos + stoim + variant;
                label1.Text = itog + "$";
            }
        }

        private void MetroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton1.Checked == true)
            {
                
                metroRadioButton2.Checked = false;
                metroRadioButton3.Checked = false;
            }
        }

        private void MetroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton2.Checked == true)
            {
                variant = 20;
                metroRadioButton1.Checked = false;
                metroRadioButton3.Checked = false;
                itog = vznos + stoim + variant;
                label1.Text = itog + "$";
            }
        }

        private void MetroTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if (!char.IsDigit(e.KeyChar)&& e.KeyChar != '\b')
            {
                e.Handled = true;
            }
         
        }

        private void MetroTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBox2.Text == string.Empty)
            {
                vznos = 0;
                itog = vznos + stoim + variant;
                label1.Text = itog + "$";
            }
            else
            {
                vznos = Convert.ToInt32(metroTextBox2.Text);
                itog = vznos + stoim + variant;
                label1.Text = itog + "$";
            }
            
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            int errorcount=0;
            string errorLog = "Исправьте ошибки:\n";
            if (metroComboBox1.Text == "")
            {
                error.SetError(metroComboBox1, "Ошибка");
                errorcount++;
                errorLog += errorcount + ". Не выбран способ оплаты\n";
            }
            if (metroTextBox2.Text == "")
            {
                error.SetError(metroTextBox2, "Ошибка");
                errorcount++;
                errorLog += errorcount + ". Не указан взнос\n";
            }
            if (bunifuCheckbox1.Checked==false  
                  &&bunifuCheckbox2.Checked == false 
                    && bunifuCheckbox3.Checked == false)
            {
                error.SetError(metroLabel2, "Ошибка");
                errorcount++;
                errorLog += errorcount + ". Не выбран вид марафона\n";
            }
            if (errorcount != 0)
            {
                MessageBox.Show(errorLog, "Произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                vznos = Convert.ToInt32(metroTextBox2.Text);
                itog = vznos + stoim + variant;
                label1.Text = itog + "$";
                string regdate = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
                Random r = new Random();
                int charityid = r.Next(1, 10);

                string query = ""; // Переменная не используется. Ну а вдруг ты не знал?
                int shlish; //денис александрович, идите в жопу
                Slishy(); // Сам иди :(((
                MessageBox.Show("В теории вы зареганы, по факту система не работает...", "Продам гараж"); 

            }
        }

        private void Slishy()
        {
            Console.WriteLine("Сам иди в жопа ахахахха");
            Console.ReadKey();
        }

        private void Register(string query)
        {

        }
       
        private void MetroRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton3.Checked == true)
            {
                variant = 45;
                metroRadioButton2.Checked = false;
                metroRadioButton1.Checked = false;
                itog = vznos + stoim + variant;
                label1.Text = itog + "$";
            }
        }

        private void BunifuCheckbox2_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox2.Checked == true)
            {
                distance = 21;
                stoim = 75;
                bunifuCheckbox1.Checked = false;
                bunifuCheckbox3.Checked = false;
                itog = vznos + stoim + variant;
                label1.Text = itog + "$";
            }
        }

        private void BunifuCheckbox3_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox3.Checked == true)
            {
                distance = 5;
                stoim = 20;
                bunifuCheckbox1.Checked = false;
                bunifuCheckbox2.Checked = false;
                itog = vznos + stoim + variant;
                label1.Text = itog + "$";
            }
        }

    }
}
