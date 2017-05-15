using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Yogesh Ghimire
//700643983
namespace GhimireFinal
{
    public partial class GhimireFinal : Form
    {
        public GhimireFinal()
        {
            InitializeComponent();
        }

        //Closes the application on click of exit button
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ghimire700643983_Load(object sender, EventArgs e)
        {
            try
            {
                ConnectionData.Connection connection = new ConnectionData.Connection();
                DataTable dataTable = connection.GetDataTable(); //Retrieve datatable

                //Create a binding source
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                //sort based on author id
                bindingSource.Sort = "au_id";

                AuthorIdComboBox.Items.Clear(); //Clear combobox before proceeding
                AuthorIdComboBox.DataSource = bindingSource;

                AuthorIdComboBox.DisplayMember = "au_id";

                AuthorIdComboBox.DataBindings.Add("text", bindingSource, "au_id", false, DataSourceUpdateMode.Never);
                FullNameTextBox.DataBindings.Add("text", bindingSource, "fullname", false, DataSourceUpdateMode.Never);
                PriceTextBox.DataBindings.Add("text", bindingSource, "price", false, DataSourceUpdateMode.Never);
                TitleTextBox.DataBindings.Add("text", bindingSource, "title", false, DataSourceUpdateMode.Never);


            }
            catch (Exception ex)
            {
                ResultMessageLabel.Text = ex.Message; //display error message
            }

        }
    }
}
