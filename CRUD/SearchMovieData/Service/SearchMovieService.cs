using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SearchMovieData.Service
{
    class SearchMovieService
    {
        public int inputIdCode(string inputId, ref Model.ErrorData errorData)
        {
            Func<string, Model.ErrorData, int> validateMovieId = (arg1, arg2) =>
            {
                if (string.IsNullOrWhiteSpace(arg1))
                {
                    arg2.Errors = "Please enter a valid movie id";
                    return -1;
                }

                else
                {
                    try
                    {
                        int inputMovieId = Convert.ToInt32(inputId);
                        if (inputMovieId < 0)
                        {
                            arg2.Errors = "The input Movie Id cannot be negative";
                        }
                        return inputMovieId;
                    }
                    catch (Exception exception)
                    {

                        arg2.Errors = exception.Message;
                        return -1;
                    }
                }
            };
            return validateMovieId(inputId, errorData);
        }
    }
}
