using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SearchMovieData
{
    public partial class MovieData : Form
    {
        public MovieData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service.SearchMovieService searchMovieService = new Service.SearchMovieService();
            Model.ErrorData errorData = new Model.ErrorData();
            int movieCode = searchMovieService.inputIdCode(MovieIdTextBox.Text, ref errorData);
            string label = (!string.IsNullOrWhiteSpace(errorData.Errors)) ? ErrorMessage.Text = (errorData.Errors) : ErrorMessage.Text = "";
            HollywoodLibrary.HollywoodDataLibrary dataLibrary = new HollywoodLibrary.HollywoodDataLibrary();
            SqlCommand command = null;
            SqlDataReader reader = null;
            command = dataLibrary.GetSqlCommand(movieCode);
            if (command != null)
            {
                reader = dataLibrary.GetSqlDataReader(command);
                if (reader != null)
                {
                    DataTable dataTable = dataLibrary.GetDataTable(reader);
                    DataGridView.DataSource = dataTable;
                }
            }
        }
    }
}
