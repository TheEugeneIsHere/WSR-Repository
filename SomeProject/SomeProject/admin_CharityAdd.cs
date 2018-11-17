using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeProject
{
    public partial class admin_CharityAdd : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = connection.AzureConnection();
        Bitmap logo;
        byte[] photo;
        string filePath;

        public admin_CharityAdd()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = connection.voteTime - DateTime.Now;
            metroLabel4.Text = timeremaining.Days + " дней " + timeremaining.Hours +
            " часов и " + timeremaining.Minutes + " минут до Нового Года";
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            admin_Charity charityForm = new admin_Charity();
            charityForm.Show();
            this.Hide();
            this.Dispose();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageSelector = new OpenFileDialog
            {
                Filter = "PNG|*.png|JPEG|*.jpg,*.jpeg,*.jpe,*.jfif|All files (*.*)|*.*",
                Title = "Выберите логотип.."
            };

            if (imageSelector.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    filePath = imageSelector.FileName;
                    photo = GetPhoto(filePath);
                    logo = new Bitmap(filePath);
                    pictureBox3.Image = logo;
                    pictureBox3.Invalidate();
                    metroTextBox3.Text = filePath;
                    filePath = imageSelector.SafeFileName;
                    imageSelector.Dispose();
                }
                catch
                { 
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void InsertCharityOrg(string filePath, byte[] photo)
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(
                   "INSERT INTO Charity (CharityName, CharityDescription, CharityLogoImage, CharityLogo) VALUES (@CharityName, @CharityDescription, @CharityLogoImage, @CharityLogo)", con);

                com.Parameters.Add("@CharityName",
                    SqlDbType.NVarChar, 100).Value = metroTextBox1.Text;
                com.Parameters.Add("@CharityDescription",
                    SqlDbType.NVarChar, 2000).Value = metroTextBox2.Text;
                com.Parameters.Add("@CharityLogo",
                   SqlDbType.NVarChar, 50).Value = filePath;
                com.Parameters.Add("@CharityLogoImage",
                    SqlDbType.Image, photo.Length).Value = photo;

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
                MessageBox.Show("Успешная вставка");
            }
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text != "" && metroTextBox2.Text != "")
            {
                //Здесь что-то сложное будет, наверное
                InsertCharityOrg(filePath, photo);
                metroTextBox1.Text = string.Empty;
                metroTextBox2.Text = string.Empty;
                metroTextBox3.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Введите название/описание организации", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            admin_Charity adminMenu_Clarity = new admin_Charity();
            adminMenu_Clarity.Show();
            this.Hide();
            this.Dispose();
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
