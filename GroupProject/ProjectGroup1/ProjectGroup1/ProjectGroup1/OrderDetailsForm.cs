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
using System.Windows.Forms;
using ProjectGroup1.Entities;

namespace ProjectGroup1
{
    public partial class OrderDetailsForm : Form
    {
        private int orderID;

        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; }

        }

        public CustomerDetails custDetails;

        public CustomerDetails CustDetails
        {
            get { return custDetails; }
            set { custDetails = value; }

        }
        public OrderDetailsForm()
        {
            InitializeComponent();
        }
        //Load all the order details placed - with Order ID
        private void OrderDetails_Load(object sender, EventArgs e)
        {
            SqlConnection connection = null;
            DataTable table = new DataTable();
            try
            {
                DaoLayer.CustomerDBLayer dbLayer = new DaoLayer.CustomerDBLayer();
                connection = dbLayer.GetConnection();
                string sql = "SELECT * FROM CUSTOMER_ORDER WHERE Order_ID = @orderID";
                SqlDataReader reader = dbLayer.GetUserDetails(sql, orderID);      
               // SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                  table.Load(reader);
                  reader.Close();
                // Append details to summary grid
                  SummaryGridView.DataSource = table;
                  SummaryGridView.ReadOnly = true;
            }
                catch(Exception exception){
                    MessageBox.Show(exception.Message);
                }
            finally
            {
                //close connection
                connection.Close();

            }

        }

        private void SummaryGridView_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

        }
    }
}
