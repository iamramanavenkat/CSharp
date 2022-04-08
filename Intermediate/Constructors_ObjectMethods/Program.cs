using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_ObjectMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Stud stud1 = new Stud("Kim", "Arts", 9.2); //Making stud 1 using constructors
                Stud stud2 = new Stud("John", "Business", 8.2);
                Console.WriteLine(stud1.isDistinction());
                Console.WriteLine(stud2.isDistinction());


                Console.ReadLine();

            }
        }
    }
}
