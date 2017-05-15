using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGroup1
{
    public partial class GroceryStoreMainForm : Form
    {
        public GroceryStoreMainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GroceryStoreMainForm_Load(object sender, EventArgs e)
        {
            orderToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = false;
            registerToolStripMenuItem.Enabled = true;
            loginToolStripMenuItem.Enabled = true;
            HomeForm homeForm = new HomeForm();
            homeForm.MdiParent = this;
            homeForm.Size = this.ClientRectangle.Size;
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            homeForm.Show();
        }
        //load LoginPage click of login button
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login logon = new Login();
            logon.MdiParent = this;
            logon.Show();
        }
        //load Register Page on click of register button
        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAccount createAccountPage = new CreateAccount();
            createAccountPage.MdiParent = this;
            createAccountPage.Show();
        }
        ////load LoadPage on click of About button in menu
        private void aboutStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.MdiParent = this;
            aboutUs.Show();
        }
        ////load Orders for the loggedin customer on click of My Orders button in menu
        private void myOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyOrders myorders = new MyOrders();
            myorders.MdiParent = this;
            myorders.Show();
        }
         ////load place orders on click of place orders button in menu
        private void placeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login ls = new Login ();
            string name = UserDetailsForm.loginID_Myorders;
            ls.MdiParent = this;
            ls.loadOrderPage(name);
        }
        ////load logout on click of logout button in menu
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeForm hf = new HomeForm();
            hf.MdiParent = this;
            hf.Show();
            disble();
        }

        //Enable menu
        public void enableMenu()
        {
            orderToolStripMenuItem.Enabled = true;
            registerToolStripMenuItem.Enabled = false;
            loginToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = true;
        }
        //Disable menu
        public void disble()
        {
            orderToolStripMenuItem.Enabled = false;
            registerToolStripMenuItem.Enabled = true;
            loginToolStripMenuItem.Enabled = true;
            logoutToolStripMenuItem.Enabled = false;
        }
        public void getLoginPage()
        {
            Login logon = new Login();
            logon.MdiParent = this;
            logon.Show();

        }
        
    }
}
