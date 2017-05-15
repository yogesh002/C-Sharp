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
using ProjectGroup1.Entities;

namespace ProjectGroup1
{
    public partial class MyOrders : Form
    {
        public string loginID;

        public string LoginID
        {
            get { return loginID; }
            set { loginID = value; }

        }

        public MyOrders()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MyOrders_Load(object sender, EventArgs e)
        {
            Entities.UserDetails orderDetails = new Entities.UserDetails();

            SqlConnection connection = null;
            DataTable table = new DataTable();
            try
            {
                

                DaoLayer.CustomerDBLayer dbLayer = new DaoLayer.CustomerDBLayer();
                connection = dbLayer.GetConnection();
                string name = UserDetailsForm.loginID_Myorders;

                string sql = "SELECT * FROM CUSTOMER_ORDER WHERE Login_ID = @loginId";
                SqlDataReader reader = dbLayer.GetAllCustOrders(sql, name);
                // SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                table.Load(reader);
                reader.Close();
                dataGridView1.DataSource = table;
                dataGridView1.ReadOnly = true;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                connection.Close();

            }
        }
    }
}
