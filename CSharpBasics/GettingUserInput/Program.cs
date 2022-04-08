using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting User Input - Interactive");
            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Your Age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + ". You're " + age + " years old.");
            Console.ReadLine();

        }
    }
}
