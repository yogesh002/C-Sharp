using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectGroup1.Service;
using System.Windows.Forms;

//created by Group1
//Adhikari(700639980), Alapati(700646035), Ghimire(700643983)



namespace ProjectGroup1
{
    public partial class Login : Form
    {
        UserDetailsForm userDetailsForm = new UserDetailsForm();
        MyOrders myorders = new MyOrders();

        public Login()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Null Checks on mandatory fields
            if (string.IsNullOrEmpty(UsernameTextBox.Text))
            {
                errorProvider1.SetError(UsernameTextBox, "Username is required!");
                return;
            }
            else if (string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                errorProvider1.SetError(PasswordTextBox, "Password is required!");
                return;
            }

            if (UsernameTextBox.Text.Length > 10)
            {
                errorProvider1.SetError(UsernameTextBox, "UserName cannot me more than 10 !");
                return;
            }
            else if (PasswordTextBox.Text.Length > 10)
            {
                errorProvider1.SetError(PasswordTextBox, "Password cannot me more than 10 !");
                return;
            }
            
            string loginID = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;



            CustomerService cs = new CustomerService();
            //validate usrname and password with database
            bool validCred = cs.ValidateLogin(loginID, password);
            if (validCred)
            {
                ProjectGroup1.GroceryStoreMainForm f = new ProjectGroup1.GroceryStoreMainForm();
                ((GroceryStoreMainForm)this.MdiParent).enableMenu();
                loadOrderPage(loginID);
            }
            if (!validCred)
            {
                DisplayError displayError = new DisplayError();
                displayError.ErrrorMessages = "The username and password combination is not valid.";
                displayError.MdiParent = this.MdiParent;
                displayError.Show();
            }

        }

        public void loadOrderPage(string loginID)
        {
            //load main Order page
            userDetailsForm.UserName = loginID;
            myorders.LoginID = loginID;
            userDetailsForm.MdiParent = this.MdiParent;
            userDetailsForm.Show();
        }
    }
}
