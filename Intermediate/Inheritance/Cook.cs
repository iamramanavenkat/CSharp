using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Cook
    {
        public void Fish()
        {
            Console.WriteLine("Preparing Fish");
        }
        public void Rice()
        { 
            Console.WriteLine("Rice is boiling"); 
        }
        public void Salad()
        {
            Console.WriteLine("Preparing salad");
        }
        public virtual void Biriyani()
        {
            Console.WriteLine("Biriyani - in process");
        }

    }
}
