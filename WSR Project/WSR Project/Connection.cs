using System;
using System.Data.SqlClient;

namespace WSRProject
{
     class Сonnection
    {
        /*уютный уголок максюши*/
        public static string Mail { get; set; } 
        public static string Password { get; set; }
        public static string Fname { get; set; }
        public static string Lname { get; set; }
        
        /* Уютный Готэм Дениса */
        private TimeSpan TimeRemaining = new DateTime(2018, 12, 31, 23, 59, 59) - DateTime.Now;
        public static string EditMail { get; set; }
      
        public string GetTime()
        {
            string Time = TimeRemaining.Days + " дней " + TimeRemaining.Hours +
            " часов и " + TimeRemaining.Minutes + " минут до Нового Года";
            return Time;
        }
       
        /* Бэтмобиль */
        public static SqlConnection AzureConnection()
        {
            string connectionString = @"Server=tcp:wsr.database.windows.net,1433;Initial Catalog=WSR;" +
                "Persist Security Info=False;User ID=Kursacheg;Password=Sharaga0264;" +
                "MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=5;";

            return new SqlConnection(connectionString);
        }

    }
}