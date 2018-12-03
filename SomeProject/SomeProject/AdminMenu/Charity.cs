﻿using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SomeProject
{
    public partial class aCharity : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = Сonnection.AzureConnection();

        public aCharity()
        {
            InitializeComponent();
            timer1.Start();
            if (!backLoad.IsBusy) backLoad.RunWorkerAsync();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            Сonnection counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }

        private void CharityLoad()
        {
            try
            {
                con.Open();
                metroGrid1.DataSource = null;
                metroGrid1.Columns[0].DefaultCellStyle.NullValue = Properties.Resources.tile_Blago;
                SqlDataAdapter ad = new SqlDataAdapter("SELECT CharityName, CharityDescription, CharityLogo FROM Charity", con);
                ad.Fill(wSRDataSetCharity1, "Charity");
                backLoad.CancelAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            aCharityAdd CharityAddForm = new aCharityAdd
            {
                Location = Location
            };
            CharityAddForm.Show();
            Hide();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            AdminForm AdminMenu = new AdminForm
            {
                Location = Location
            };
            AdminMenu.Show();
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

        private void BackLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            CharityLoad();
        }

        private void BackLoad_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            metroGrid1.DataSource = charityBindingSource;
            LoaderPictureBox.Visible = false;
            LoaderPictureBox.Enabled = false;
        }
    }
}
