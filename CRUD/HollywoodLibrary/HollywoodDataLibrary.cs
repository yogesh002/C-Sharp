using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HollywoodLibrary
{
    public class HollywoodDataLibrary
    {
        private SqlParameter GetSqlParameters(int movieId)
        {
            SqlParameter sqlParameter_movie = new SqlParameter("@MovieId", SqlDbType.Int);
            sqlParameter_movie.Value = movieId;
            return sqlParameter_movie;
        }


        public SqlCommand GetSqlCommand(int movieId)
        {
            string query = "SELECT Actors.LastName, Actors.FirstName, Actors.DateOfBirth FROM Actors INNER JOIN Roles ON Actors.ActorID = Roles.ActorID WHERE MovieID = @MovieID";
            SqlCommand sqlCommand = null;
            try
            {
                SqlParameter sqlParameter = GetSqlParameters(movieId);
                sqlCommand = new SqlCommand(query, HollywoodConnectionData.GetSqlConnection());
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.Add(sqlParameter);
                return sqlCommand;
            }
            catch (Exception)
            {
                HollywoodConnectionData.CloseSqlConnection();
                sqlCommand.Dispose();
                return null;
            }


        }

        public SqlDataReader GetSqlDataReader(SqlCommand sqlCommand)
        {
            HollywoodConnectionData.GetSqlConnection();
            HollywoodConnectionData.OpenSqlConnection();
            try
            {
                return sqlCommand.ExecuteReader();

            }
            catch (Exception)
            {
                HollywoodConnectionData.CloseSqlConnection();
                sqlCommand.Dispose();
                return null;
            }
        }


        public DataTable GetDataTable(SqlDataReader sqlDataReader)
        {
            DataTable dataTable = new DataTable();
            try
            {
                dataTable.Load(sqlDataReader);
                sqlDataReader.Close();

            }
            catch (Exception)
            {
                HollywoodConnectionData.CloseSqlConnection();

            }
            return dataTable;
        }
    }
}
