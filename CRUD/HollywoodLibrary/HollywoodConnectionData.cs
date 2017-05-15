using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace HollywoodLibrary
{
    class HollywoodConnectionData
    {
        public static SqlConnection sqlConnection;
        private const string CONNECTION_STRING = "HollywoodLibrary.Properties.Settings.HollywoodConnectionString";
        public static SqlConnection GetSqlConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings[CONNECTION_STRING].ToString();
            return sqlConnection = (sqlConnection == null) ? (new SqlConnection(connectionString)) : sqlConnection;
        }

        public static void OpenSqlConnection()
        {
            if ((sqlConnection != null) && (sqlConnection.State == ConnectionState.Closed))
            {
                sqlConnection.Open();
            }
        }
        public static void CloseSqlConnection()
        {
            if (sqlConnection != null && (sqlConnection.State == ConnectionState.Open))
            {
                sqlConnection.Close();
            }
        }
    }
}
