using System;
using System.Threading.Tasks;

namespace WSRProject
{
    public partial class SponsorshipList : MetroFramework.Forms.MetroForm
    {
        public SponsorshipList()
        {
            InitializeComponent();
            SponsorshipLoadAsync();
            timer1.Start();
        }
        private void TimerTick(object sender, EventArgs e)
        {
            var counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }
        private async void SponsorshipLoadAsync()
        {
            metroGrid1.DataSource = null;
            pictureBox2.Visible = true;
            pictureBox2.Enabled = true;
            await Task.Factory.StartNew(() =>
            {
                sponsorshipTableAdapter.Fill(wSRDataSetMAX.Sponsorship);
            });
            metroGrid1.DataSource = sponsorshipBindingSource;
            pictureBox2.Visible = false;
            pictureBox2.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var MainMenu = new Form1();
            MainMenu.Show();
            Hide();
        }
    }
}
