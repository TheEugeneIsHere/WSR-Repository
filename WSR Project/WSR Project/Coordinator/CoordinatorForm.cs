using System.Windows.Forms;

namespace WSRProject
{
    public partial class CoordinatorForm : MetroFramework.Forms.MetroForm
    {
        public CoordinatorForm()
        {
            InitializeComponent();
            FormClosing += new FormClosingEventHandler(AppClose.GoodBye);
        }

        

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            var form = new Login();
            form.Show();
            Hide();
        }

        private void metroTile1_Click(object sender, System.EventArgs e)
        {
            var run = new ViewRunner();
            run.Show();
            Hide();
        }

        private void metroTile3_Click(object sender, System.EventArgs e)
        {
            var spons = new SponsCoord();
            spons.Show();
            Hide();
        }

        private void metroTile1_Click_1(object sender, System.EventArgs e)
        {
            var reg = new ViewRegistration();
            reg.Show();
            Hide();
        }
    }
}
