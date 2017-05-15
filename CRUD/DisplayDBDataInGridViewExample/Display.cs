using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayDBDataInGridViewExample
{
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            //For each DataTable in a DataSet, an Adapter is created. It is appended with the name of that particular DataTable
            //1. Create the Adapter
            ParishramDataSetTableAdapters.personaldetailsTableAdapter personalDetailsTableAdapter = new ParishramDataSetTableAdapters.personaldetailsTableAdapter();
            //2. Create a new instance of DataTable from your DataSet
            ParishramDataSet.personaldetailsDataTable parishramDetailsDataTable = new ParishramDataSet.personaldetailsDataTable();
            //3. Fill the DataTable through DataTableAdapter
            personalDetailsTableAdapter.Fill(parishramDetailsDataTable);

            //Create a BindingSource. This has DataSource property that holds data from various data sources. In our case, data is coming from one of the DataTables in the DataSet
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = parishramDetailsDataTable;

            //Set the DataSource proprety of the gridview we defined in the form as the same bindingSoure we generated above
            DisplayGridView.DataSource = bindingSource;

        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {

        }
    }
}
