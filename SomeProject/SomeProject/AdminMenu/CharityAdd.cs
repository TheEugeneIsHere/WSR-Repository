using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SomeProject
{
    public partial class aCharityAdd : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = Сonnection.AzureConnection();
        byte[] photo;
        string filePath;

        public aCharityAdd()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = Сonnection.GetTime - DateTime.Now;
            metroLabel4.Text = timeremaining.Days + " дней " + timeremaining.Hours +
            " часов и " + timeremaining.Minutes + " минут до Нового Года";
        }

        public static byte[] GetPhoto(string filePath)
        {
            FileStream stream = new FileStream(
                filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            byte[] photo = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();

            return photo;
        }

        private void InsertCharity(byte[] photo)
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("INSERT INTO Charity (CharityName, CharityDescription, CharityLogo)" +
                    " VALUES (@CharityName, @CharityDescription, @CharityLogo)", con);

                com.Parameters.Add("@CharityName", SqlDbType.NVarChar, 100).Value = metroTextBox1.Text;
                com.Parameters.Add("@CharityDescription", SqlDbType.NVarChar, 2000).Value = metroTextBox2.Text;
                com.Parameters.Add("@CharityLogo", SqlDbType.Image, photo.Length).Value = photo;

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
                MessageBox.Show("Благотворительная организация успешно добавлена в систему WSR", "WSR: Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                aCharity CharityForm = new aCharity();
                CharityForm.Show();
                Hide();
            }
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text != "" && metroTextBox2.Text != "")
            {
                InsertCharity(photo);
                metroTextBox1.Text = string.Empty;
                metroTextBox2.Text = string.Empty;
                metroTextBox3.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Введите название/описание организации", "WSR: Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            aCharity CharityForm = new aCharity();
            CharityForm.Show();
            Hide();
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageSelector = new OpenFileDialog
            {
                Filter = "All files (*.*)|*.*|JPEG|*.jpg,*.jpeg,*.jpe,*.jfif|PNG|*.png",
                Title = "Выберите логотип..",
            };

            if (imageSelector.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    
                    filePath = imageSelector.FileName;
                    photo = GetPhoto(filePath);
                    pictureBox3.Image = new Bitmap(filePath);
                    pictureBox3.Invalidate();
                    metroTextBox3.Text = filePath;
                }
                catch
                {
                    DialogResult result = MessageBox.Show("Невозможно открыть выбранный файл",
                    "WSR: Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            aCharity CharityForm = new aCharity();
            CharityForm.Show();
            Hide();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Form1 MainForm = new Form1();
            MainForm.Show();
            Hide();
        }

        private void GoodbyeUser(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dialog = MessageBox.Show("Вы действительно желаете выйти из приложения?", "WSR: Выход",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    Application.OpenForms[0].Close();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

    }
}
