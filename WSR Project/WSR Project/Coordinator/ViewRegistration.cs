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
    public partial class ViewRegistration : MetroFramework.Forms.MetroForm
    {
        public ViewRegistration()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var coord = new CoordinatorForm
            {
                Location = Location
            };
            coord.Show();
            Hide();
        }

        private void ViewRegistration_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wSRDataSetMAX.Registration". При необходимости она может быть перемещена или удалена.
            this.registrationTableAdapter.Fill(this.wSRDataSetMAX.Registration);

        }
    }
}
