using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Return
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Methods & Return Statements");
            Methods();
            int CubedNumber = ReturnsCube(5);
            Console.WriteLine("The Cubed number is "+CubedNumber);
            Console.ReadLine();
        }
        static void Methods()
        {
            Console.WriteLine("This line is in Method.");
        }
        static int ReturnsCube(int num)
        {
            int Ans = num * num * num;
            return Ans;
        }
       
    }
}
