using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace RNRLibrary
{
    public class RNRDataClass
    {
        public SqlConnection sqlConnection;
        private const string CONNECTION_STRING = "RNRLibrary.Properties.Settings.RnrBooksConnectionString";
        public SqlConnection GetSqlConnection()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings[CONNECTION_STRING].ToString();
                sqlConnection = (sqlConnection == null) ? (sqlConnection = new SqlConnection(connectionString)) : sqlConnection;
                return sqlConnection;
            }
            catch (Exception exception)
            {
                throw new Exception(String.Format("There was an issue while handling connection string and opening the sql connection. {0} ", exception.Message));
            }

        }

        public void OpenSqlConnection()
        {
            if (!IsSqlConnectionOpen())
            {
                sqlConnection.Open();
            }
        }

        private bool IsSqlConnectionOpen()
        {
            return (sqlConnection.State == ConnectionState.Closed) ? false : true;
        }

        public void CloseSqlConnection()
        {
            if (IsSqlConnectionOpen())
            {
                sqlConnection.Close();
            }
        }
    }
}
