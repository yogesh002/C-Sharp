using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectGroup1.Entities;
using ProjectGroup1.DaoLayer;
using System.Data;
using System.Data.SqlClient;
using System.Web;

//created by Group1
//Adhikari(700639980), Alapati(700646035), Ghimire(700643983)

namespace ProjectGroup1.Service
{
    class CustomerService
    {
        private string errorData;
        public string LastError { get; set; }

        public int Add(UserDetails userDetails)
        {
            CustomerDBLayer customerDBLayer = new CustomerDBLayer();
            string sql = "INSERT INTO [dbo].[User_Table] ([Login_Id], [First_Name], [Middle_Name], [Last_Name], [Email], [Phone_Number], [Password]) values(@username, @first,@middle, @last , @email , @phoneNum ,@password)";

            SqlParameter param1 = new SqlParameter("@username", userDetails.UserName);
            SqlParameter param2 = new SqlParameter("@first", userDetails.FirstName);
            SqlParameter param3 = new SqlParameter("@middle", userDetails.MiddleName);
            SqlParameter param4 = new SqlParameter("@last", userDetails.LastName);
            SqlParameter param5 = new SqlParameter("@email", userDetails.Email);
            SqlParameter param6 = new SqlParameter("@phoneNum", userDetails.PhoneNumber);
            SqlParameter param7 = new SqlParameter("@password", userDetails.Password);

            SqlCommand cmd = customerDBLayer.GetCommand(sql);
            cmd.Parameters.Add(param1);
            cmd.Parameters.Add(param2);
            cmd.Parameters.Add(param3);
            cmd.Parameters.Add(param4);
            cmd.Parameters.Add(param5);
            cmd.Parameters.Add(param6);
            cmd.Parameters.Add(param7);

            try
            {
                customerDBLayer.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return -1;
            }
            finally
            {
                customerDBLayer.Close();
                cmd.Dispose();
            }
        }

        public bool ValidateLogin(string loginID, string password)
        {
            //to validate username and password
            CustomerDBLayer customerDBLayer = new CustomerDBLayer();
            SqlParameter param1 = new SqlParameter("@loginID", SqlDbType.VarChar);
            param1.Value = loginID;

            SqlParameter param2 = new SqlParameter("@password", SqlDbType.VarChar);
            param2.Value = password;
            try
            {
                DataTable dt = customerDBLayer.SomeMethod("SELECT * FROM User_Table WHERE Login_Id = @loginID and Password = @password", CommandType.Text, param1, param2);
                return dt.Rows.Count > 0;

            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return false;
            }
        }

    
        public void IsCustomerInputValid(string phone, string firstName, string address)
        {
             //validations
            if (string.IsNullOrWhiteSpace(firstName))
            {
                string errorMessage = "Please enter your first name";
                isCustomerInputValid(firstName, errorMessage);
            }
            if (phone.Length != 10)
            {
                string errorMessage = "The phone number should be 10 digits.";
                isCustomerInputValid(phone, errorMessage);
            }

            if (string.IsNullOrWhiteSpace(address))
            {
                string errorMessage = "Please enter your address";
                isCustomerInputValid(address, errorMessage);
            }
        }

        //use of generics : Validation
        private void isCustomerInputValid<T>(T input, string message)
        {
            throw new Exception(string.Format("{0} \n You Entered: {1}",message, input));
        }

    }
}
