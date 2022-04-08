using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc();
            Console.ReadLine();
        }
        static void Calc()
        {
            Console.WriteLine("Caculator using if else if and else statements: ");
            Console.Write("Enter Number 1:  ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Operator '+'  '-'  '*'  '/'  :");
            string op = Console.ReadLine();
            Console.Write("Enter Number 2:  ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("Invalid Character");
            }
        }
    }
}
