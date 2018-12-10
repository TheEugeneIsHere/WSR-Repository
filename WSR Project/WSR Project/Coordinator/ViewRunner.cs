using System;
using System.Data.SqlClient;
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
    public partial class ViewRunner : MetroFramework.Forms.MetroForm
    {
        public ViewRunner()
        {
            InitializeComponent();
        }
        SqlConnection con = Сonnection.AzureConnection();
        private void LoadData()
        {
          

            

            con.Open();

            string query = "select firstname,lastname,dateofbirth,users.Email from runner join users on runner.email=users.email; ";

            SqlCommand command = new SqlCommand(query, con);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            reader.Close();

            con.Close();

            foreach (string[] s in data)
                metroGrid2.Rows.Add(s);
        }
        private void ViewRunner_Load(object sender, EventArgs e)
        {
            LoadData();
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
    }
}
