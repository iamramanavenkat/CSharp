using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tools mytool = new Tools();  Can't create like this. Because "Tools" is a static method

            Console.WriteLine(Math.Sqrt(144)); // Math is a static class - public static class Math

            Tools.SayHello("Ramanavenkat");
            Console.ReadLine();
        }
    }
}
