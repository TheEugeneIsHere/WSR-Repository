using System.Windows.Forms;

namespace SomeProject
{
    public partial class CoordinatorForm : Form
    {
        public CoordinatorForm()
        {
            InitializeComponent();
            FormClosing += new FormClosingEventHandler(AppClose.GoodBye);
        }
    }
}
