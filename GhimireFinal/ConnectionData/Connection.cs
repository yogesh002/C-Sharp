using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace ConnectionData
//Yogesh Ghimire
//700643983
{
    public class Connection
    {
        private SqlConnection sqlConnection;
        private SqlDataAdapter sqlAdapter;
        private string dBResultMessage;

        //public property to set the result message - success or failure
        public string DBMessage
        {
            get
            {

                return dBResultMessage;

            }
            set
            {
                dBResultMessage = value;
            }
        }




        private const string connectionString = "ConnectionData.Properties.Settings.pubsConnectionString";

        //Retrieve sqlConnection
        public SqlConnection GetSqlConnection()
        {
            string connectionDataString = ConfigurationManager.ConnectionStrings[connectionString].ToString();
            sqlConnection = (sqlConnection == null) ? (new SqlConnection(connectionDataString)) : sqlConnection;
            return sqlConnection;
        }

        //Open the sql Connection if closed
        public void OpenSqlConnection()
        {
            if ((sqlConnection != null) && sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }


        //Close the sql connection if open
        public void CloseSqlConnection()
        {
            if (sqlConnection != null && sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }


        //Gets SqlCommand
        public SqlCommand GetSqlCommand()
        {
            string query = "SELECT A.au_id, A.au_lname, A.au_fname, A.au_fname +' '+ A.au_lname as fullname, T.title, T.price, TA.au_id FROM authors as A JOIN titleauthor as TA ON A.au_id = TA.au_id JOIN titles as T ON TA.title_id = T.title_id";
            sqlConnection = this.GetSqlConnection();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            return command;
        }

        //Gets DataTable 
        public DataTable GetDataTable()
        {
            SqlCommand command = null;
            DataTable dataTable = null;
            try
            {
                DataSet dataSet = new DataSet();
                command = GetSqlCommand();
                this.OpenSqlConnection();
                sqlAdapter = new SqlDataAdapter(command);
                sqlAdapter.Fill(dataSet); //Filling dataset
                dataTable = dataSet.Tables[0];
                return dataTable;
            }
            catch (Exception ex)
            {
                DBMessage = ex.Message;
                return dataTable;
            }
            finally
            {
                this.CloseSqlConnection(); //Closes the connection
                command.Dispose();  //Release the resources
            }
        }
    }
}
