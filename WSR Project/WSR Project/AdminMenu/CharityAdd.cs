using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WSRProject
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
            FormClosing += new FormClosingEventHandler(AppClose.GoodBye);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            var counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }

        public static byte[] GetPhoto(string filePath)
        {
            var stream = new FileStream(
                filePath, FileMode.Open, FileAccess.Read);
            var reader = new BinaryReader(stream);
            byte[] photo = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();

            return photo;
        }

        private void InsertCharity(byte[] photo)
        {
            try
            {
                Random rnd = new Random();
                int kek = rnd.Next(100, 6000);
                con.Open();
                var com = new SqlCommand("INSERT INTO Charity (CharityId, CharityName, CharityDescription, CharityLogo) VALUES (@CharityId, @CharityName, @CharityDescription, @CharityLogo)", con);

                com.Parameters.Add("@CharityId", SqlDbType.Int).Value = kek;
                com.Parameters.Add("@CharityName", SqlDbType.NVarChar, 100).Value = metroTextBox1.Text;
                com.Parameters.Add("@CharityDescription", SqlDbType.NVarChar, 2000).Value = metroTextBox2.Text;
                com.Parameters.Add("@CharityLogo", SqlDbType.Image, photo.Length).Value = photo;

                com.ExecuteNonQuery();
                MessageBox.Show("Благотворительная организация успешно добавлена в систему WSR", "WSR: Информация",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();

                var CharityForm = new aCharity
                {
                    Location = Location
                };
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
            var CharityForm = new aCharity
            {
                Location = Location
            };
            CharityForm.Show();
            Hide();
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            var imageSelector = new OpenFileDialog
            {
                Filter = "All files (*.*)|*.*|JPEG|*.jpg,*.jpeg,*.jpe,*.jfif|PNG|*.png",
                Title = "Выберите логотип..",
            };

            if (imageSelector.ShowDialog() == DialogResult.OK)
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
            var CharityForm = new aCharity
            {
                Location = Location
            };
            CharityForm.Show();
            Hide();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            var MainForm = new Form1
            {
                Location = Location
            };
            MainForm.Show();
            Hide();
        }

    }
}
