//created by Group1
//Adhikari(700639980), Alapati(700646035), Ghimire(700643983)
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectGroup1.Entities;
using ProjectGroup1.Service;

namespace ProjectGroup1
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            //validating the user input
            if (string.IsNullOrEmpty(userNameTextBox.Text))
            {
                errorProvider1.SetError(userNameTextBox, "Username is required!");
                return;
            }
            else if (string.IsNullOrEmpty(FirstNameTextBox.Text))
            {
                errorProvider1.SetError(FirstNameTextBox, "First Name is required!");
                return;
            }
            else if (string.IsNullOrEmpty(LastNameTextBox.Text))
            {
                errorProvider1.SetError(LastNameTextBox, "Last Name is required!");
                return;
            }
            else if (string.IsNullOrEmpty(EmailIDTextBox.Text))
            {
                errorProvider1.SetError(EmailIDTextBox, "Email is required!");
                return;
            }
            else if (string.IsNullOrEmpty(PhoneNumberTextBox.Text))
            {
                errorProvider1.SetError(PhoneNumberTextBox, "Phone Number is required!");
                return;
            }
            else if (string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                errorProvider1.SetError(PasswordTextBox, "Password is required!");
                return;
            }
            else
            {
                if (userNameTextBox.Text.Length > 10)
                {
                    errorProvider1.SetError(userNameTextBox, "UserName cannot me more than 10 !");
                    return;
                }
                else if (FirstNameTextBox.Text.Length > 10)
                {
                    errorProvider1.SetError(FirstNameTextBox, "FirstName cannot me more than 10 !");
                    return;
                }
                else if (LastNameTextBox.Text.Length > 10)
                {
                    errorProvider1.SetError(LastNameTextBox, "LastName cannot me more than 10 !");
                    return;
                }
                else if (EmailIDTextBox.Text.Length > 35)
                {
                    errorProvider1.SetError(EmailIDTextBox, "EmailID cannot me more than 35 !");
                    return;
                }
                else if (PhoneNumberTextBox.Text.Length != 10)
                {
                    errorProvider1.SetError(PhoneNumberTextBox, "Phone Number must be 10 digit !");
                    return;
                }else if(!(EmailIDTextBox.Text.Contains("@")) || !((EmailIDTextBox.Text.Contains(".com"))|| (EmailIDTextBox.Text.Contains(".COM")))) {
                    errorProvider1.SetError(EmailIDTextBox, "Invalid Email .Please enter again !");
                    return;
                }
                else if (PasswordTextBox.Text.Length > 10)
                {
                    errorProvider1.SetError(PasswordTextBox, "Password cannot me more than 10 !");
                    return;
                }

                //validate username:


                // validate phone Number
                String num = (PhoneNumberTextBox.Text);
                if (num.Trim().Length != 10)
                {
                    errorProvider1.SetError(PhoneNumberTextBox, "Invalid Phone Number.Please re-enter.");
                    return;
                }

                int phoneNumber = Convert.ToInt32(PhoneNumberTextBox.Text);
                UserDetails userDetails = new UserDetails(userNameTextBox.Text.Trim(), FirstNameTextBox.Text.Trim(), MiddleNameTextBox.Text.Trim(), LastNameTextBox.Text.Trim(), EmailIDTextBox.Text.Trim(), phoneNumber, PasswordTextBox.Text.Trim());

                CustomerService custSer = new CustomerService();

                int counter = custSer.Add(userDetails);

               // MessageBox.Show("counter" + counter);
               // Console.Write("counter:" + counter);

                if (counter == 1)
                {
                    MessageBox.Show("User Created Succesfully.Please Login.");
                    //   this.Close();
                    ((GroceryStoreMainForm)this.MdiParent).getLoginPage();
                }
                else
                {
                    MessageBox.Show("Username is already used.Please enter new username.");
                    userNameTextBox.Clear();
                }

            }




        }
        //accept only digits 
        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Enter only Numbers
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void FirstNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {// Enter only alphabets
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void MiddleNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Enter only alphabets
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void LastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Enter only alphabets
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
