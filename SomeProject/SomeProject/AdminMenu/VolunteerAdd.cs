using System;
using System.Windows.Forms;

namespace SomeProject
{
    public partial class aVolunteerAdd : MetroFramework.Forms.MetroForm
    {
        public aVolunteerAdd()
        {
            InitializeComponent();
            timer1.Start();
            FormClosing += new FormClosingEventHandler(AppClose.GoodBye);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            Сonnection counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }

        private void MetroTextBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Этого произойти было не должно"); 
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            aVolunteer VolunteerForm = new aVolunteer
            {
                Location = Location
            };
            VolunteerForm.Show();
            Hide();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Form1 MainForm = new Form1
            {
                Location = Location
            };
            MainForm.Show();
            Hide();
        }

    }
}
