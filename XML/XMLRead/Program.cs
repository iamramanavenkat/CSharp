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
            xdoc.Load(@"H:\CSharp\Code\XMLOperations\ReadXML\Students.xml");
            xdoc.Save(Console.Out);
            Console.ReadLine();
        }

        static void TxtRead()
        {
            XmlTextReader xtr = new XmlTextReader(@"H:\CSharp\Code\XMLOperations\ReadXML\Students.xml");
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
