using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AlSatProjesi_01.DataAccessLayer.Connections
{
    class ConnectionDAL
    {
        private static SqlConnection connectionObj;

        public static SqlConnection ConnectionObj
        {
            get
            {
                if (connectionObj == null)
                {
                    connectionObj = new SqlConnection(ConfigurationManager.ConnectionStrings["CsAlSat"].ConnectionString);
                }
                return connectionObj;
            }
            set
            {
                connectionObj = value;
            }
        }


        public static void Open()
        {
            if (ConnectionObj.State == ConnectionState.Closed) ConnectionObj.Open();
        }

        public static void Close()
        {
            if (ConnectionObj.State == ConnectionState.Open) ConnectionObj.Close();
        }
    }
}
