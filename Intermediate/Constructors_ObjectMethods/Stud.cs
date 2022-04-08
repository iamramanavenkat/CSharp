using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_ObjectMethods
{
    class Stud
    {
        public string name;
        public string dept;
        public double gpa;

        public Stud(string aName, string aDept, double aGpa) //Constructor
        {
            name = aName;
            dept = aDept;
            gpa = aGpa;
        }

        public bool isDistinction() //Object method
        {
            if (gpa > 8.5)
            {
                return true;
            }
            return false;
        }
    }
}
