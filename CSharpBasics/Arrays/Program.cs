using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays - Multiple Values/Collection of Individual Values");
            //IntArray();
            //StringArray();
            LoopArray();
            Console.ReadLine();


        }
        static void IntArray()
        {
            //Integer array
            int[] evenNumbers = { 2, 4, 6, 8, 10 };
            Console.WriteLine(evenNumbers[2]);
            evenNumbers[2] = 4;
            Console.WriteLine(evenNumbers[2]);
        }
        static void StringArray()
        {
            //String Array
            string[] trees = { "Coconut", "Banyan", "Neem", "Palm" };
            Console.WriteLine(trees);//Returns the type of the data

            //foreach(string i in trees)
            //{
            //    Console.WriteLine(i);
            //}
        }
        public static void LoopArray()
        {
            int[] numbers = { 41, 85, 23, 91, 79, 36, 45 };
            foreach (int num in numbers)
            {
                Console.Write(num + ", ");
            }
            Array.Sort(numbers);
            Console.WriteLine("\nSorted Array");
            foreach (int num in numbers)
            {              
                Console.WriteLine(num + ", ");
            }
            Array.Reverse(numbers);
            Console.WriteLine("Reversed Array: ");
            foreach(int num in numbers)
            {
                Console.WriteLine(num+", ");
            }

            //Looping Array using for Loop
            Console.WriteLine("Looping Array using for Loop");
            for (int i =0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}
