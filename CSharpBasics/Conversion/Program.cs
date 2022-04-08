using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversions");
            StringToInt();
            Console.ReadLine();
        }
        static void StringToInt()
        {
            Console.Write("Enter Your Age: ");
            string str_age = Console.ReadLine();
            int age = Convert.ToInt32(str_age);
            Console.WriteLine(age);
        }
    }
}
