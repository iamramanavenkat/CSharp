using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 115;
            string result = a > b ? "A is big" : b > c ? "B is big" : c > b ? "C is big" : "";
            //Console.WriteLine(a > b ? "A is big" : "B is big");
            //bool result = b > a ? true : false;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
