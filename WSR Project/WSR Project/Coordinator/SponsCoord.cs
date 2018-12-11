using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace WSRProject
{
    public partial class SponsCoord : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = Сonnection.AzureConnection();

        public SponsCoord()
        {
            InitializeComponent();
            SponsLoadAsync();
            timer1.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            var counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }

        private async void SponsLoadAsync()
        {
            pictureBox2.Enabled = true;
            pictureBox2.Visible = true;
            await Task.Factory.StartNew(() =>
            {
                metroGrid1.DataSource = null;
                con.Open();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM Sponsorship", con);
                ad.Fill(wSRDataSetMAX.Sponsorship);
                con.Close();
                //this.sponsorshipTableAdapter.Fill(this.wSRDataSetMAX.Sponsorship);
            });
            metroGrid1.DataSource = sponsorshipBindingSource;
            pictureBox2.Enabled = false;
            pictureBox2.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var MainMenu = new Form1();
            MainMenu.Show();
            Hide();
        }
    }
}
