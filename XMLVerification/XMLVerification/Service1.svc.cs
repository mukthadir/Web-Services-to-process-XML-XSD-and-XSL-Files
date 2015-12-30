using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace XMLVerification
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string Verification(string xmlUrl, string xsdUrl) 
        {
            try
            {
                // setting for xml reader adding provided xsd for validation
                XmlReaderSettings readerSettings = new XmlReaderSettings();
                readerSettings.ValidationType = ValidationType.Schema;
                readerSettings.Schemas.Add("XMLVerification", XmlReader.Create(xsdUrl.Trim()));

                // creating xml document from given xml url
                XmlReader xmlReader = XmlReader.Create(xmlUrl.Trim(), readerSettings);
                XmlDocument document = new XmlDocument();
                document.Load(xmlReader);

                // validating if xml is as per xsd or not
                ValidationEventHandler validationEventHandler = new ValidationEventHandler(EventHandler);
                return "No Error";
            }
            catch (Exception ex)
            {
                return ("Validation Failed: " + ex.Message);
            }
        }

        public void EventHandler(object o, ValidationEventArgs args) {}

        public string XPathSearch(string xmlUrl, string xPath)
        {
            try
            {
                StringBuilder output = new StringBuilder();

                // creating xml document from the given url
                XmlDocument document = new XmlDocument();
                document.Load(xmlUrl.Trim());

                // getting the node list as per xPath
                XmlNodeList nodeList = document.DocumentElement.SelectNodes(xPath.Trim());

                if (nodeList.Count == 0)
                {
                    return "Given XPath is not valid. Please provide valid XPath.";
                }

                // saving data of each node in string builder
                foreach (XmlNode node in nodeList)
                {
                    output.Append(node.InnerText + "\n");
                }

                return output.ToString();
            }
            catch (Exception ex)
            {
                return "Wrong XPath Provided. " + ex.Message;
            }
        }
    }
}
