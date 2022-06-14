using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "All you need to know";
            bool success = !string.IsNullOrWhiteSpace(msg);
            (bool, int, string) triple = (success, 4, msg);
            Console.WriteLine(triple.Item1);
            Console.WriteLine(triple.Item2);
            Console.WriteLine(triple.Item3);

            //Initialization
            (int, int) HeightWeight = (168, 55);

            //Assignment
            HeightWeight = (159, 52);

            Console.WriteLine(HeightWeight.Item1 + "_" + HeightWeight.Item2);

            //Return value
            (bool, int) GetSameOrBigger(int num1, int num2)
            {
                return (num1 == num2, num1 > num2 ? num1 : num2);
            }
            Console.WriteLine("\nGetSameOrBigger");
            Console.WriteLine(GetSameOrBigger(25, 12));
            MyTuple(5);
            Console.WriteLine(MyTuple());
            Console.ReadLine();
        }
    }
     static bool MyTuple(int num)
        {
        Console.WriteLine("Tuples");
        }
}
