using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ReadXML
{
    class Program
    {
        static void Main(string[] args)
        {
           // XmlDoc();
           TxtRead();
        }

        static void XmlDoc()
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(@"I:\CSharp\XML\XMLRead\Students.xml");
            xdoc.Save(Console.Out);
            xdoc.Save(@"I:\CSharp\XML\XMLRead\Stud_Load.xml");
            Console.ReadLine();
        }

        static void TxtRead()
        {
            XmlTextReader xtr = new XmlTextReader(@"I:\CSharp\XML\XMLRead\Students.xml");
            while (xtr.Read())
            {
                if(xtr.NodeType == XmlNodeType.Element && xtr.Name == "Name")
                {
                    string val = xtr.ReadElementContentAsString();
                    Console.WriteLine(val);
                    Console.ReadLine();

                }
            }
        }
    }
}
