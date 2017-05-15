using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNRForm
{
    class ErrorData
    {
        private string errorContent;

        public string ErrorContent
        {
            get
            {
                return errorContent;
            }
            set
            {
                if (value != null || string.IsNullOrWhiteSpace(value))
                {
                    errorContent = value;
                }
            }
        }
    }
}
