using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZBilisim.KayitSistemi.DataAccessLayer.Connections
{
    class ConnectionDAL
    {
        static SqlConnection connection;
        public static SqlConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);
                }
                return connection;
            }
            set
            {
                connection = value;
            }
        }
        public static void Open()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
        }

        public static void Close()
        {
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }
    }
}
