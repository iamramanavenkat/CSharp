using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Methods / Operations");
            String_Methods("Coconut", "Apple");
            Console.ReadLine();
        }
        static void String_Methods(string tree, string fruit)
        {
            Console.WriteLine("The given word is " + tree + " and " + fruit);
            Console.WriteLine(tree.ToUpper());
            Console.WriteLine(tree.ToLower());
            Console.WriteLine(tree.Contains("nut"));
            Console.WriteLine(tree.Substring(2, 3));
            Console.WriteLine((tree + fruit).ToUpper());
            string treefruit = string.Concat(tree, fruit);
            Console.WriteLine(treefruit);

        }

    }
}
