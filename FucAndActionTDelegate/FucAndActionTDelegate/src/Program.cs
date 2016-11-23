using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Yogesh Ghimire
namespace FucAndActionTDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calling convertInputToUpperCase()
            Console.WriteLine(ConvertInputToUpperCase());
            Console.WriteLine("--------Press key to continue-------");
            Console.ReadKey();

            //Calling CalculateSum()
            Console.WriteLine(CalculateSum());
            Console.WriteLine("--------Press key to continue-------");
            Console.ReadKey();

            //Calling ReverseCharacterToString()
            Console.WriteLine(ReverseCharacterToString());
            Console.WriteLine("--------Press key to continue-------");
            Console.ReadKey();

            //Example 4
            Console.WriteLine(ReverseCharactersAndConvertUpperCase());
            Console.WriteLine("--------Press key to continue-------");
            Console.ReadKey();

            //Example 5:
            Console.WriteLine(EnumerateArrayAndReverse());
            Console.WriteLine("--------Press key to continue-------");
            Console.ReadKey();
        }

        //Example 1 inolving Func<T>
        //Writing static to call in main method
        private static string ConvertInputToUpperCase()
        {
            //Defining a func<T> delegate
            //accepts a string and returns a string
            Func<string, string> conversion = s =>
            {
                return s.ToUpper();
            };
            //calling func<T> function
            return conversion("passing lower case test strings");
        }

        //Example 2 inolving Func<T>
        private static int CalculateSum()
        {
            Func<string, string, int> generateSum = (arg1, arg2) =>
            {
                int result = int.Parse(arg1) + int.Parse(arg2);
                return result;
            };
            //calling func<T> method defined above

            return generateSum("1", "9");
        }

        //Example 3 inolving Func<T>
        private static string ReverseCharacterToString()
        {
            Func<char[], string> conversion = (argument1) =>
            {
                Array.Reverse(argument1);
                string result = new string(argument1);
                return result;

            };
            char[] input = { 'p', 'a', 'n' };
            return conversion(input);
        }

        //Example 4 involving Action<T>
        private static string ReverseCharactersAndConvertUpperCase()
        {
            string output = null;
            Action<char[]> conversion = argument =>
            {
                Array.Reverse(argument);
                output = new string(argument).ToUpper();
            };
            //making a call to conversion(char[] input)
            char[] testInput = { 'a', 'p', 'e' };
            conversion(testInput);
            return output;
        }

        //Example 5 using Action<T> delegate
        private static string EnumerateArrayAndReverse()
        {
            //defining a lambda expression below that does the business logic
            Func<string, string> handleInput = argument =>
            {
                char[] inputCharacters = argument.ToCharArray();
                Array.Reverse(inputCharacters);
                return new string(inputCharacters).ToUpper();
            };

            Func<string[], string> conversion = argument =>
            {
                IEnumerable<string> result = argument.Select(handleInput);
                List<string> outputList = new List<string>();
                foreach (var item in result)
                {
                    outputList.Add(item);

                }
                foreach (var item in outputList)
                {
                    Console.WriteLine(item);
                }

                return "Task Completed!";

            };

            string[] inputArrays = { "banana", "apple", "mango" };
            return conversion(inputArrays);
        }
    }
}

//Some concepts learnt:
//Array.reverse(char[] input)
//new string(char[] input)
//string.ToCharArray() 
//IEnumerable<string> result = stringarray.Select(pointer to delegate function to perform business logic);