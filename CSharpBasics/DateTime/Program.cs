using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(TimeZoneInfo i in TimeZoneInfo.GetSystemTimeZones())
            {
                Console.WriteLine(i.Id);
            }
            Console.ReadLine();
        }
    }
}
