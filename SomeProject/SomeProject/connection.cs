using System;
using System.Data.SqlClient;

namespace SomeProject
{
    class connection
    {
        public static DateTime voteTime = new DateTime(2018, 12, 31, 23, 59, 59);
        public static string editMail;
        public static string imageView;

        public static SqlConnection AzureConnection()
        {
            string connectionString = @"Server=tcp:wsrcurse.database.windows.net,1433;Initial Catalog=WSR;" +
                "Persist Security Info=False;User ID=TheEugene;Password=TimCookIsGay7.;" +
                "MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=10;";

            return new SqlConnection(connectionString);
        }

        /*уютный уголок максюши*/
        public static string mail;
        public static string password;
        public static bool theme;
        /*конец уголка*/
    }
}