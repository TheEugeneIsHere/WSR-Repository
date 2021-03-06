﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WSRProject
{
    public partial class EditProfile : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = Сonnection.AzureConnection();

        string gender;
        string contry;
        DateTime ishdate;

        public EditProfile()
        {
            InitializeComponent();
            timer1.Start();
            metroLabel12.Text = Сonnection.Mail;
            metroTextBox2.Text = Сonnection.Fname;
            metroTextBox3.Text = Сonnection.Lname;
            GetGender();
            metroComboBox1.Text = gender;
            metroDateTime1.Value = ishdate;
            metroComboBox2.Text = contry;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            var counter = new Сonnection(); // Создание экземпляра класса Connection
            timerLabel.Text = counter.GetTime(); // Для доступа к публичному методу возвращаемого типа string
        }

        private void GetGender()
        {
            string strSQL;
            con.Open();
            var command = con.CreateCommand();
            strSQL = ("SELECT @Gender=Gender,@DateOfBirth=DateOfBirth,@CountryCode=CountryCode FROM Runner WHERE email=@email");
            SqlParameter Gender,date,country;
            command.CommandText = strSQL;
            Gender = command.Parameters.Add("@Gender", SqlDbType.VarChar, 20);
            Gender.Direction = ParameterDirection.Output;
            date = command.Parameters.Add("@DateOfBirth", SqlDbType.DateTime, 20);
            date.Direction = ParameterDirection.Output;
            country = command.Parameters.Add("@CountryCode", SqlDbType.VarChar, 20);
            country.Direction = ParameterDirection.Output;
            command.Parameters.AddWithValue("@email", Сonnection.Mail);
            command.ExecuteNonQuery();
            gender = Convert.ToString(Gender.Value);
            contry = Convert.ToString(country.Value);
            ishdate = Convert.ToDateTime(date.Value);
            con.Close();
        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            var run = new RunnerForm
            {
                Visible = true
            };
            Hide();
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            string query;
            DateTime date = metroDateTime1.Value;
            string data = date.ToString("yyyy-MM-dd");
            if (metroTextBox8.Text == "")
            {
                query = @"UPDATE Users SET Firstname='"+metroTextBox2.Text+"',LastName='"+metroTextBox3.Text+"' WHERE Email = '"+metroLabel12.Text+"'; " +
                    "UPDATE Runner SET DateOfBirth = '"+data+"',CountryCode ='"+metroComboBox2.Text+"',Gender ='"+metroComboBox1.Text+"' WHERE Email = '"+metroLabel12.Text+"'; ";
                Edit(query);
            }
            else // Все запросы исправлены - Бэтмен
            {
                if (metroTextBox8.Text != "")
                {
                    query = @"UPDATE Users SET Firstname='"+ metroTextBox2.Text + "',LastName='"+ metroTextBox3.Text + "', Password='"+metroTextBox8.Text+"' WHERE Email = '"+metroLabel12.Text+"'; " +
                        "UPDATE Runner SET DateOfBirth = '"+data+"',CountryCode = '"+ metroComboBox2.Text + "',Gender = '"+ metroComboBox1.Text + "' WHERE Email = '" + metroLabel12.Text + "'; ";
                    Edit(query);
                }
            }
        }

        void Edit(string query)
        {
            var ediеProfile = new SqlCommand(query, con);
            try
            {
                con.Open();
                ediеProfile.ExecuteNonQuery();
                MessageBox.Show("Информация обновлена!");
                con.Close();
                ediеProfile.Dispose();
            }
            catch (Exception ex)
            {
                ediеProfile.Dispose();
                con.Close();
                MessageBox.Show(ex.ToString());
            }
            con.Close();
        }

        private void MetroTextBox2_TextChanged(object sender, EventArgs e)
        {
            metroButton2.Enabled = true;
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            this.genderTableAdapter.Fill(this.wSRDataSetMAX.Gender);
            this.countryTableAdapter.Fill(this.wSRDataSetMAX.Country);
        }


    }
}
