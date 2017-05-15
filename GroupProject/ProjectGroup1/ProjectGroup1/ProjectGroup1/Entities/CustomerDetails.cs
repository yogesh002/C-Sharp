using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//created by Group1
//Adhikari(700639980), Alapati(700646035), Ghimire(700643983)

namespace ProjectGroup1.Entities
{
    public class CustomerDetails
    {
        //customer order variables
        private int orderId;
        private string fullName;
        private int phoneNumber;
        private string fullAddress;
        private int onionAmount;
        private int tomatoAmount;
        private int lettuceAmount;
        private int chickenAmount;
        private string shippingAmount;
        private int totalAmount;
        private string loginID;

        public CustomerDetails()
        {

        }
        public CustomerDetails(string loginid ,int orderId, string fullNam, int phoneNumb, string fullAdd, int onionAmt, int tomatoAmt, int lettuceAmt, int chickenAmt, string shippingAmt, int totalAmt)
        {
            LoginID = loginid;
            FullName = fullNam;
            PhoneNumber = phoneNumb;
            Address = fullAdd;
            Tomato = tomatoAmt;
            Onion = onionAmt;
            Lettuce = lettuceAmt;
            Chicken = chickenAmt;
            Shipping = shippingAmt;
            Total = totalAmt;
        }
        public int OrderID
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public string LoginID
        {
            get { return loginID; }
            set { loginID = value; }
        }

        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Address
        {
            get { return fullAddress; }
            set { fullAddress = value; }
        }
        public int Tomato
        {
            get { return tomatoAmount; }
            set { tomatoAmount = value; }
        }
        public int Onion
        {
            get { return onionAmount; }
            set { onionAmount = value; }
        }
        public int Lettuce
        {
            get { return lettuceAmount; }
            set { lettuceAmount = value; }
        }
        public int Chicken
        {
            get { return chickenAmount; }
            set { chickenAmount = value; }
        }
        public string Shipping
        {
            get { return shippingAmount; }
            set { shippingAmount = value; }
        }
        public int Total
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }
    }
}
