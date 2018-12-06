using System.Windows.Forms;

namespace WSRProject
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
