using System.Security.Cryptography.Xml;
using System.Xml;

namespace EMCryptographyXml
{
    public class SignedXmlWithId : SignedXml
    {
        public override XmlElement GetIdElement(XmlDocument document, string idValue)
        {
            if (!(document.SelectSingleNode($"//*[@Id='{idValue}']") is XmlElement idElement))
            {
                idElement = base.GetIdElement(document, idValue);
            }

            return idElement;
        }
    }
}
