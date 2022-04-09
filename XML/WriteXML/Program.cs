using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WriteXML
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"I:\CSharp\XML\WriteXML\Stud_Details.xml";
            XmlTextWriter xwrite = new XmlTextWriter(filename, System.Text.Encoding.UTF8);
            xwrite.Formatting = Formatting.Indented;
            xwrite.WriteStartDocument();
            xwrite.WriteComment("Creating XML Document using C#");
            xwrite.WriteStartElement("Students");
            for (int i = 1; i <=2; i++)
            {
                xwrite.WriteStartElement("Student");
                Console.WriteLine("Enter Student Name " + i);
                xwrite.WriteElementString("Name", Console.ReadLine());
                Console.WriteLine("Enter Student Class "+i);
                xwrite.WriteElementString("Class", Console.ReadLine());
                xwrite.WriteEndElement();
            }
            xwrite.WriteEndElement();
            xwrite.WriteEndDocument();
            xwrite.Flush();
            xwrite.Close();
        }
    }
}
