using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class SpecialCook : Cook
    {
        public override void Biriyani()
        {
            Console.WriteLine("Making Special Biriyani");
        }
        public void Newdish()
        {
            Console.WriteLine("New dish...");
        }
    }
}
