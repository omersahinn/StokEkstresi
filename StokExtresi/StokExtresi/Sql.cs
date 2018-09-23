using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokExtresi
{
    public class Sql
    {
        // Singleton pattern ile sadece tek Connection instance alınır.
        private static SqlConnection connection;
       
        public static SqlConnection Connection
        {
            get
            {
                // App.config den StokExtresi isimli connectionString ile bağlantı kuruluyor.
                connection = connection ?? new SqlConnection(ConfigurationManager.ConnectionStrings["StokExtresi"].ConnectionString);
                return connection;
            }
        }
    }
}
