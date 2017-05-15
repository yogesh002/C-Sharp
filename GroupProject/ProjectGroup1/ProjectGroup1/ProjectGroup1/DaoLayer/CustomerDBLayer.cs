using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectGroup1.Entities;
using System.Data;
using System.Collections;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

//created by Group1
//Adhikari(700639980), Alapati(700646035), Ghimire(700643983)

namespace ProjectGroup1.DaoLayer
{
    class CustomerDBLayer
    {
        private SqlConnection connection;

        string connectionString = ConfigurationManager.ConnectionStrings["ProjectGroup1.Properties.Settings.mydatabaseConnectionString"].ToString();
        //get Connection
        public SqlConnection GetConnection()
        {
            if (connection == null)
                connection = new SqlConnection(connectionString);
            return connection;
        }
        // Open the connection
        public void Open()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //Close the connection
        public void Close()
        {
            connection.Close();
        }

        //Gets sqlCommand
        public SqlCommand GetCommand(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, this.GetConnection());
            cmd.CommandType = CommandType.Text;
            return cmd;
        }

        //Gets DataTable
        public DataTable SomeMethod(string procnameOrQuery, CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null)
        {
            SqlCommand cmd = new SqlCommand(procnameOrQuery, this.GetConnection());
            try
            {
                cmd.CommandType = cmdType;
                UserDetails us = new UserDetails();
                if (param1 != null)
                    cmd.Parameters.Add(param1);
                if (param2 != null)
                    cmd.Parameters.Add(param2);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            finally
            {
                cmd.Dispose();
                this.Close();
            }

        }

        //Gets SqlDataReader
        public SqlDataReader GetUserDetails(string query, int orderID)
        {
            SqlCommand command = null;
            SqlDataReader reader = null;
            try
            {
                SqlParameter sqlParameter = new SqlParameter("@orderID", SqlDbType.Int);
                sqlParameter.Value = orderID;
                command = new SqlCommand(query, this.GetConnection());
                command.Parameters.Add(sqlParameter);
                this.Open();
                reader = command.ExecuteReader();
                Console.WriteLine("Counter" + reader);
                return reader;
            }
            catch (Exception e)
            {
                Console.WriteLine("exception:" + e);
                return null;
            }
        }
        public SqlDataReader GetAllCustOrders(string query, string loginId)
        {
            SqlCommand command = null;
            SqlDataReader reader = null;
            try
            {
                SqlParameter sqlParameter = new SqlParameter("@loginId", SqlDbType.VarChar);
                sqlParameter.Value = loginId;
                command = new SqlCommand(query, this.GetConnection());
                command.Parameters.Add(sqlParameter);
                this.Open();
                reader = command.ExecuteReader();
                Console.WriteLine("Counter" + reader);
                return reader;
            }
            catch (Exception e)
            {
                Console.WriteLine("exception:" + e);
                return null;
            }
        }

        public List<int> InsertOrderDetails(CustomerDetails customerDetails)
        {
            //for customer order
            List<int> list = new List<int>();
            string query = "INSERT INTO [dbo].[Customer_Order] ([Login_ID], [Phone_Number], [Address], [Onions], [Tomatos], [Lettuce], [Chicken], [Total_Amount], [Shipping], [Order_ID] ,[Customer_Name]) VALUES (@LoginId, @PhoneNumber, @Address, @Onion, @Tomato, @Lettuce, @Chicken, @Total, @Shipping, @autoGen, @customerName)";
            SqlParameter loginParameter = new SqlParameter("@LoginId", SqlDbType.VarChar);
            loginParameter.Value = customerDetails.LoginID;
            SqlParameter customerName = new SqlParameter("@customerName", SqlDbType.VarChar);
            customerName.Value = customerDetails.FullName;
            SqlParameter phoneParameter = new SqlParameter("@PhoneNumber", SqlDbType.NVarChar);
            phoneParameter.Value = customerDetails.PhoneNumber;
            SqlParameter addressParameter = new SqlParameter("@Address", SqlDbType.NVarChar);
            addressParameter.Value = customerDetails.Address;
            SqlParameter onionParameter = new SqlParameter("@Onion", SqlDbType.NVarChar);
            onionParameter.Value = customerDetails.Onion;
            SqlParameter tomatoParameter = new SqlParameter("@Tomato", SqlDbType.Int);
            tomatoParameter.Value = customerDetails.Tomato;
            SqlParameter lettuceParameter = new SqlParameter("@Lettuce", SqlDbType.Int);
            lettuceParameter.Value = customerDetails.Lettuce;
            SqlParameter chickenParameter = new SqlParameter("@Chicken", SqlDbType.Int);
            chickenParameter.Value = customerDetails.Chicken;
            SqlParameter totalParameter = new SqlParameter("@Total", SqlDbType.Int);
            totalParameter.Value = customerDetails.Total;
            SqlParameter shippingParameter = new SqlParameter("@Shipping", SqlDbType.NVarChar);
            shippingParameter.Value = customerDetails.Shipping;
            SqlParameter autoGen = new SqlParameter("@autoGen", SqlDbType.Int);
            int autoGenVal = this.getMaxOrderID();
            autoGen.Value = autoGenVal;


            SqlCommand cmd = new SqlCommand(query, this.GetConnection());
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();

            AddParametersInCmd(cmd, loginParameter);
            AddParametersInCmd(cmd, phoneParameter);
            AddParametersInCmd(cmd, addressParameter);
            AddParametersInCmd(cmd, onionParameter);
            AddParametersInCmd(cmd, tomatoParameter);
            AddParametersInCmd(cmd, lettuceParameter);
            AddParametersInCmd(cmd, chickenParameter);
            AddParametersInCmd(cmd, totalParameter);
            AddParametersInCmd(cmd, shippingParameter);
            AddParametersInCmd(cmd, autoGen);
            AddParametersInCmd(cmd, customerName);

            if (cmd != null)
            {
                try
                {
                    this.Open();
                    int inserted = 0;

                    list.Add(autoGenVal);
                    inserted = cmd.ExecuteNonQuery();
                    list.Add(inserted);

                }
                finally
                {
                    this.Close();
                    cmd.Dispose();
                }
            }
            return list;
        }


        private void AddParametersInCmd<T>(SqlCommand cmd, T input)
        {
            if (input != null)
            {
                cmd.Parameters.Add(input);
            }

        }

        //for auto increment
        public int getMaxOrderID()
        {
            int autoNumber = 0;
            SqlCommand command = null;
            SqlDataReader reader = null;
            try
            {
                string query = "Select Max(Order_ID) from Customer_Order";
                command = new SqlCommand(query, this.GetConnection());

                this.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string val = reader[0].ToString();
                    if (val == "")
                    {
                        autoNumber = 1;
                        return autoNumber;
                    }
                    else
                    {
                        autoNumber = Convert.ToInt32(reader[0].ToString());
                        autoNumber = autoNumber + 1;
                        return autoNumber;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("exception:" + e);

            }
            finally
            {
                command.Dispose();
                this.Close();
            }
            return autoNumber;
        }

    }
}
