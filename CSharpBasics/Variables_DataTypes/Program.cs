using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables and DataTypes");
            VariablesDataTypes();
            Console.ReadLine();
        }
        static void VariablesDataTypes()
        {
            int num = 14;
            string name = "Ramanavenkat";
            double gpa = 7.88;
            char grade = 'A';
            bool isPass = true;
            Console.WriteLine("The person " + name + " and register number is " + num + "." + " He got " + gpa + " in College and the grade is " + grade + "." + " Finally his state is pass and its " + isPass);
        }
    }
}
