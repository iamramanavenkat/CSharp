using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers");
            Console.WriteLine(40);
            Console.WriteLine(-17.45);
            Console.WriteLine(3 * 6);
            Console.WriteLine(5 / 2);//Returns Quotient
            Console.WriteLine(5 % 2);//Returns Remainder
            Console.WriteLine(4 * 3 - 2);

            //Methods
            increment();
            Decrement();
            MathOp(4,3);
            BasicCalc(2,4);

            Console.ReadLine();
        }
        static void increment()
        {
            int num = 7;
            num++;
            Console.WriteLine("\n"+num);
        }
        static void Decrement()
        {
            int num = 6;
            num--;
            Console.WriteLine("\n"+num+"\n");
        }
        static void MathOp(int num1, int num2)
        {
            double value = -23.31;
            Console.WriteLine(Math.Abs(value));
            Console.WriteLine(Math.Pow(num1,num2));
            Console.WriteLine(Math.Sqrt(num1));
            Console.WriteLine(Math.Max(45,40));
            Console.WriteLine(Math.Min(40,39));
            Console.WriteLine(Math.Round(value));
      
        }
        static void BasicCalc(int num1,int num2)
        {
            Console.WriteLine("\nBasic Calculation using Two Numbers");
            Console.WriteLine("Addition:  " + (num1 + num2));
            Console.WriteLine("Subtraction: " + (num1 - num2));
            Console.WriteLine("Multiplication: "+(num1*num2));
            Console.WriteLine("Division: "+(num1/num2));
        }
    }
}
