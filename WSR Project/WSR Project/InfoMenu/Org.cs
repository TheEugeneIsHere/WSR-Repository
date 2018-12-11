using System;
using System.Threading.Tasks;

namespace WSRProject
{
    public partial class Org : MetroFramework.Forms.MetroForm
    {
        public Org()
        {
            InitializeComponent();
            OrgLoadAsync();
            timer1.Start();
        }

        private async void OrgLoadAsync()
        {
            metroGrid1.Columns[0].DefaultCellStyle.NullValue = Properties.Resources.tile_Blago;
            metroGrid1.DataSource = null;
            LoaderPictureBox.Visible = true;
            LoaderPictureBox.Enabled = true;
            await Task.Factory.StartNew(() =>
            {
                charityTableAdapter.Fill(wSRDataSetCharity.Charity);
            });
            metroGrid1.DataSource = charityBindingSource;
            LoaderPictureBox.Visible = false;
            LoaderPictureBox.Enabled = false;
        }
        private void TimerTick(object sender, EventArgs e)
        {
            var counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            var info = new InfoForm();
            info.Show();
            Hide();
        }
    }
}
