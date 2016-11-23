using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortProject
{
    class Employee
    {
        //public properties

        public string Name
        {
            get;
            private set;
        }

        public decimal Salary
        {
            get;
            private set;
        }

        //Constructor
        public Employee(string name, decimal salary)
        {
            this.Name = name;  //Note: setting public property here.
            this.Salary = salary;
        }

        //override the ToString method
        public override string ToString()
        {
            return String.Format("Name is: {0}, and the salary is: {1}", Name, Salary); //Refer to the public property
        }

        //performing some logic here based on the object of this class.
        public static bool IsSalaryLesser(Employee employeeOne, Employee employeeTwo)
        {
            return employeeOne.Salary < employeeTwo.Salary;
        }
    }
}
