using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Infrastructure.Entities
{
    public class Currencies
    {
        [XmlElement("Currency")]
        public List<Currency> currencyList = new List<Currency>();
    }
}
