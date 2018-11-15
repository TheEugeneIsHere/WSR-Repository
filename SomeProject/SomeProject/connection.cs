using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SomeProject
{
    class connection
    {
        public static DateTime voteTime = new DateTime(2018, 11, 20, 8, 20, 0);
        public static string editMail;

        public static SqlConnection AzureConnection()
        {
            string connectionString = @"Server=tcp:wsrcurse.database.windows.net,1433;Initial Catalog=WSR;" +
                "Persist Security Info=False;User ID=TheEugene;Password=TimCookIsGay7.;" +
                "MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=10;";

            return new SqlConnection(connectionString);
        }

        /*уютный уголок максюши*/
        public static string mail; // Уот сучка Максюша 
        public static string password;
        /*конец уголка*/
    }
}