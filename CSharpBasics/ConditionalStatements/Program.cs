using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conditional Statements: \n\t1. if statement\n\t2. else statement\n\t3. else if statement\n\t4. switch statement");
            ifstmt();
            Console.WriteLine("The greater number among the 3 number is: " + greater3(45, 53, 12));
            Console.ReadLine();
        }
        static void ifstmt()
        {
            bool isMale = false;
            bool isTall = true;
            if (isMale && isTall)
            {
                Console.WriteLine("You're a tall male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You're a short male");
            }
            else if(!isMale && isTall)
            {
                Console.WriteLine("You're not a male bur you're tall");
            }
            else
            {
                Console.WriteLine("You're not a male or not a tall male or both");
            }
        }
        static int greater3(int num1, int num2, int num3)
        {
            int ans;
            if (num1>=num2 && num1 >= num3)
            {
                return num1;
            }
            else if(num2>=num1 && num2 >= num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
    }
}
