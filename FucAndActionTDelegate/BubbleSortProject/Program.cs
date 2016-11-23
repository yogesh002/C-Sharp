using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employeeArray = { new Employee("Hello", 5000),
                                        new Employee("World", 2000),
                                        new Employee("Cosmic", 1000),
                                        new Employee("Girrafe", 7000),
                                        new Employee("Tom", 555)
                                       };
            BubbleSorter.SortArray(employeeArray, Employee.IsSalaryLesser);

            //Test

            foreach (var item in employeeArray)
            {
                Console.WriteLine("The name is: {0} and the salary is: {1}: ", item.Name, item.Salary);
            }
            Console.ReadKey();
        }
    }
}
