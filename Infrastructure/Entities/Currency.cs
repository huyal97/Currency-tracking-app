using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Infrastructure.Entities
{
    public class Currency
	{
        public int Id { get; set; }

        [XmlAttribute("CurrencyCode")]
		public string CurrencyCode { get; set; }

		public string Unit { get; set; }		
        public string Isim { get; set; }
        public string CurrencyName { get; set; }		
		public string ForexBuying { get; set; }		
		public string ForexSelling { get; set; }		
		public string BanknoteBuying { get; set; }		
		public string BanknoteSelling { get; set; }
	}
}
