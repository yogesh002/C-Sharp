using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//created by Group1
//Adhikari(700639980), Alapati(700646035), Ghimire(700643983)

namespace ProjectGroup1.Entities
{
    class UserDetails
    {
        private string userName;
        private string firstName;
        private string middleName;
        private string lastName;
        private string email;
        private int phoneNumber;
        private string password;

        public UserDetails()
        {

        }

        public UserDetails(string UserNam, string FirstNam, string MiddleNam, string LastNam, string EmailID, int PhoneNum , string pass)
        {
            UserName = UserNam;
            FirstName = FirstNam;
            MiddleName  = MiddleNam;
            LastName = LastNam;
            Email = EmailID;
            PhoneNumber = PhoneNum;
            Password = pass;
        }

       public string UserName {
            get { return userName; }
            set { userName = value; }
        
        }
       public string FirstName
       {

            get {return firstName ;}
            set { firstName = value; } 
        
        }
       public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

       public string LastName 
        {
            get { return lastName; }
            set { lastName = value; } 
        }
       public string Email 
        {
            get { return  email;}
            set { email =value; }
        }
       public int PhoneNumber
       {

            get { return phoneNumber ;}
            set { phoneNumber = value;}
        
        }
       public string Password
       {
           get { return password ; }
           set { password = value; }
       }
    }
}
