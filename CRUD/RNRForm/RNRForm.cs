using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace RNRForm
{
    public partial class RNRForm : Form
    {

        private const string SQLQUERY = "SELECT ISBN, Title, Author, Publisher, Subject_Code, Subject, Fiction FROM Books join Subjects on  (SubjectCode = Subject_Code)";

        public RNRForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RNRLibrary.RNRDataClass rnrDataClass = new RNRLibrary.RNRDataClass();
            RNRLibrary.DataTableHandler dataTableHandler = new RNRLibrary.DataTableHandler();
            ErrorData errorData = new ErrorData();
            BindingSource bindingSource = new BindingSource();

            SqlConnection sqlConnection = rnrDataClass.GetSqlConnection();
            try
            {
                if (sqlConnection != null)
                {
                    rnrDataClass.OpenSqlConnection();
                    DataTable dataTable = dataTableHandler.GetDataTable(SQLQUERY, sqlConnection);
                    if (dataTable != null)
                    {
                        bindingSource.DataSource = dataTable;
                    }
                    else
                    {
                        errorData.ErrorContent = "Binding Source is null";
                    }

                    SelectAuthorTextBox.Items.Clear();
                    SelectAuthorTextBox.DataSource = bindingSource;
                    SelectAuthorTextBox.DisplayMember = "Author";
                    SelectAuthorTextBox.ValueMember = "ISBN";

                    TitleTextBox.DataBindings.Add("Text", bindingSource, "Title");
                    SubjectCodeTextBox.DataBindings.Add("Text", bindingSource, "Subject_Code");
                    SubjectTextBox.DataBindings.Add("Text", bindingSource, "Subject");
                    PublisherTextBox.DataBindings.Add("Text", bindingSource, "Publisher");
                    FictionTextBox.DataBindings.Add("Text", bindingSource, "Fiction");

                }
                else
                {
                    errorData.ErrorContent = "The sql Connection is null. Please check your connection and try again";
                }


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                rnrDataClass.CloseSqlConnection();

            }
        }
    }
}
