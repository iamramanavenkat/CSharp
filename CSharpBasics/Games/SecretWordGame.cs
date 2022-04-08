using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games
{
    class SecretWordGame
    {
        static void Main(string[] args)
        {
            string word = "Blue";
            string guess = "";
            int limit = 3;
            int count = 0;
            bool outoflimit = false;
            while ((guess != word) && !outoflimit)
            {
                if (count < limit)
                {
                    Console.WriteLine("Enter Word:  ");
                    guess = Console.ReadLine();
                    count++;
                }
                else
                {
                    outoflimit = true;
                }
            }
            if (outoflimit)
            {
                Console.Write("You Lose!");
            }
            else
            {
                Console.Write("You Win!");
            }
            Console.ReadLine();

        }
    }
}
