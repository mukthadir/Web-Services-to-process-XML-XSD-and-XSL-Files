using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string xmlPath = "http://www.public.asu.edu/~mhchoudh/Airlines.xml";
            string xsdPath = "http://www.public.asu.edu/~mhchoudh/Airlines.xsd";
            string xPath = "/Name";

            ServiceReference1.Service1Client myClient = new ServiceReference1.Service1Client();
            Console.WriteLine(myClient.Verification(xmlPath, xsdPath));

            Console.WriteLine(myClient.XPathSearch(xmlPath,xPath));
        }
    }
}
