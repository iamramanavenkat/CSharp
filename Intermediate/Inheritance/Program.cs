using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Cook usualcook = new Cook();
            SpecialCook splcook = new SpecialCook();
            usualcook.Fish();
            usualcook.Biriyani();
            splcook.Biriyani();
            Console.Read();
        }
    }
}
