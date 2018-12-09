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
    public partial class Org : MetroFramework.Forms.MetroForm
    {
        public Org()
        {
            InitializeComponent();
        }

        private void Org_Load(object sender, EventArgs e)
        {
            this.charityTableAdapter.Fill(this.wSRDataSetCharity.Charity);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var info = new InfoForm();
            info.Show();
            Hide();
        }
    }
}
