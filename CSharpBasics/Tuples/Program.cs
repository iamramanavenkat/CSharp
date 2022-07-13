using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    /*Data Structure which organizes the data.
     Holding two or more fields of any type.
    Enclosed by () - parantheses.
    */
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "CSharp World!";

            bool check = string.IsNullOrWhiteSpace(greeting);

            (bool, int, string) thrice = (check,4,greeting);

            Console.WriteLine(thrice);

            Console.WriteLine(EqualAndSum(3, 8)); //Return Value

            (int, int) operands = (4, 8); 

            Console.WriteLine(Add(operands));//Method Argument - Passing a tuple as a method paramenter/argument

            Console.ReadLine();

            
        }

        //Return Value
        static (bool, int) EqualAndSum(int num1, int num2)
        {
            return (num1 == num2, num1 + num2);
        }

        //Method Argument
        static int Add((int myVal1, int myVal2)opr)
        {
            return opr.myVal1 + opr.Item2;// We can use own name or pre defined Item1, Item2 ...
        }


    }
   
}
