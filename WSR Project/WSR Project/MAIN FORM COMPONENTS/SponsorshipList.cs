using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSRProject
{
    public partial class SponsorshipList : MetroFramework.Forms.MetroForm
    {
        public SponsorshipList()
        {
            InitializeComponent();
        }
        private void TimerTick(object sender, EventArgs e)
        {
            var counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }
        private void SponsorshipList_Load(object sender, EventArgs e)
        {
            this.sponsorshipTableAdapter.Fill(this.wSRDataSetMAX.Sponsorship);

        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var MainMenu = new Form1();
            MainMenu.Show();
            Hide();
        }
    }
}
