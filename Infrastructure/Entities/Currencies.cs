using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Infrastructure.Entities
{
    [XmlRoot(ElementName = "Tarih_Date")]
    public class Currencies
    {
        public int Id { get; set; }
        [XmlAttribute("Date")]
        public string Date { get; set; }
        [XmlElement("Currency")]
        public List<Currency> currencyList { get; set; }
    }
}
