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
            var sponsor = new SponsorshipList();
            sponsor.Show();
            Hide();
        }
    }
}
