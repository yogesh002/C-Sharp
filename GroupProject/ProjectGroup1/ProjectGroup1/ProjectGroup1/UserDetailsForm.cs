using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ProjectGroup1
{
    public partial class UserDetailsForm : Form
    {
        private string userName;
        private string firstName;
        private string middleName;
        private string lastName;
        private int phoneNumber;

        public static string loginID_Myorders;

        public  string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }
        public UserDetailsForm()
        {
            InitializeComponent();

        }
        Entities.CustomerDetails orderDetails = new Entities.CustomerDetails();

        private void UserDetailsForm_Load(object sender, EventArgs e)
        {
            WelcomeLabel.Text = "Welcome " + userName;
            loginID_Myorders = userName;
            for (int i = 0; i < 8; i++)
            {
                OnionComboBoxQuantity.Items.Add(i);
                LettuceQtyComboBox.Items.Add(i);
                TomatoComboBoxQuantity.Items.Add(i);
                chickenComboBoxQuantity.Items.Add(i);
            }
            StandardShippingRadio.Checked = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void phoneNumbertextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneNumbertextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FirstNameTextBox.Text))
            {
                errorProvider1.SetError(FirstNameTextBox, "First Name is required!");
                return;
            }
            else if (string.IsNullOrEmpty(PhoneNumbertextBox.Text))
            {
                errorProvider1.SetError(PhoneNumbertextBox, "Phone Number is required!");
                return;
            }
            else if (string.IsNullOrEmpty(AddressTextBox.Text))
            {
                errorProvider1.SetError(AddressTextBox, "Address is required!");
                return;
            }


            if (FirstNameTextBox.Text.Length > 10)
            {
                errorProvider1.SetError(FirstNameTextBox, "Name cannot me more than 10 !");
                return;
            }
            else if (PhoneNumbertextBox.Text.Length != 10)
            {
                errorProvider1.SetError(PhoneNumbertextBox, "PhoneNumber must be 10 digit !");
                return;
            }
            else if (AddressTextBox.Text.Length > 50)
            {
                errorProvider1.SetError(AddressTextBox, "AddressNumber cannot me more than 10 !");
                return;
            }
            else if (TotalAmount.Text == "0")
            {
                errorProvider1.SetError(TotalAmount, "Total Amount cannot be zero !");
                return;
            }
            
            // validate phone Number
            string num = PhoneNumbertextBox.Text;
            string firstName = FirstNameTextBox.Text;
            string address = AddressTextBox.Text;
             List<int> list = new List<int>();
            try
            {
            Service.CustomerService service = new Service.CustomerService();
            DaoLayer.CustomerDBLayer dbLayer = new DaoLayer.CustomerDBLayer();
            orderDetails.Address = AddressTextBox.Text;
            orderDetails.FullName = FirstNameTextBox.Text;
            orderDetails.LoginID = userName;
            orderDetails.PhoneNumber = Int32.Parse(PhoneNumbertextBox.Text);
            service.IsCustomerInputValid(num, firstName, address);
            list = dbLayer.InsertOrderDetails(orderDetails);
            if (list[1] != 0)
            {
                
                OrderDetailsForm orderDetail = new OrderDetailsForm();
                orderDetail.OrderID = list[0];
                orderDetails.OrderID = list[0];
                orderDetail.MdiParent = this.MdiParent;
                //TODO: need to pull data from inserted data from table
                orderDetail.Show();
            }
           
                double totalVal = System.Convert.ToDouble(TotalAmount.Text);
                int onionCount = Convert.ToInt32(OnionComboBoxQuantity.Text);
                int tomatoCount = Convert.ToInt32(TomatoComboBoxQuantity.Text);
                int letuceCount = Convert.ToInt32(LettuceQtyComboBox.Text);
                int chickenCount = Convert.ToInt32(chickenComboBoxQuantity.Text);
                string shipping = "standard";
                if (twentyFourHrRadio.Checked)
                {
                    shipping = "24";
                }
                if (twelveHrRadio.Checked)
                {
                    shipping = "12";
                }
                if (OneHourRadio.Checked)
                {
                    shipping = "1";
                }
            }
            catch (Exception exception)
            {
                ErrorMessageLabel.Text = exception.Message;
                return;
            }
        }

        private void OnionComboBoxQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(OnionComboBoxQuantity.Text);
            double total = quantity * 1.35;
            orderDetails.Onion = Convert.ToInt32(total);
            OnionsTextTotal.Text = total.ToString();
        }

        private void TomatoComboBoxQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(TomatoComboBoxQuantity.Text);
            double total = quantity * 2.35;
            orderDetails.Tomato = Convert.ToInt32(total);
            TomatosTextTotal.Text = total.ToString();
        }

        private void LettuceQtyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(LettuceQtyComboBox.Text);
            double total = quantity * 3.35;
            orderDetails.Lettuce = Convert.ToInt32(total);
            LettuceTextTotal.Text = total.ToString();
        }

        private void chickenComboBoxQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(chickenComboBoxQuantity.Text);
            double total = quantity * 4.35;
            orderDetails.Chicken = Convert.ToInt32(total);
            ChickenTextTotal.Text = total.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void OnionsTextTotal_TextChanged(object sender, EventArgs e)
        {

            CalculateTotal();
        }


        public void CalculateTotal()
        {
            double onionPrice = 0;
            int shippingPrice = 0;

            if (OnionsTextTotal != null && !string.IsNullOrWhiteSpace(OnionsTextTotal.Text))
            {
                onionPrice = System.Convert.ToDouble(OnionsTextTotal.Text);
            }

            double tomatoPrice = 0;

            if (TomatosTextTotal != null && !string.IsNullOrWhiteSpace(TomatosTextTotal.Text))
            {
                tomatoPrice = System.Convert.ToDouble(TomatosTextTotal.Text);
            }

            double letucePrice = 0;
            if (LettuceTextTotal != null && !string.IsNullOrWhiteSpace(LettuceTextTotal.Text))
            {
                letucePrice = System.Convert.ToDouble(LettuceTextTotal.Text);
            }
            double chickenPrice = 0;

            if (ChickenTextTotal != null && !string.IsNullOrWhiteSpace(ChickenTextTotal.Text))
            {
                chickenPrice = System.Convert.ToDouble(ChickenTextTotal.Text);
            }

            if (twentyFourHrRadio.Checked == true)
            {
                shippingPrice = 2;
            }
            if (twelveHrRadio.Checked == true)
            {
                shippingPrice = 3;
            }
            if (OneHourRadio.Checked == true)
            {
                shippingPrice = 4;
            }
            double TotalPrice = onionPrice + tomatoPrice + chickenPrice + letucePrice + shippingPrice;
            orderDetails.Total = Convert.ToInt32(TotalPrice);
            orderDetails.Shipping = shippingPrice.ToString();
            TotalAmount.Text = TotalPrice.ToString();
        }

        private void TomatosTextTotal_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void LettuceTextTotal_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void ChickenTextTotal_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void StandardShippingRadio_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void twentyFourHrRadio_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void twelveHrRadio_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void OneHourRadio_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

    }
}
