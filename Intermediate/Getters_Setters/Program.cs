using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getters_Setters
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie sherk = new Movie("Sherk", "Adam Adamson", "PG");
            sherk.Rating = "sky";
            Console.WriteLine(sherk.Rating);
            Console.WriteLine(avengers.Rating);
            Console.ReadLine();
        }
    }
}
