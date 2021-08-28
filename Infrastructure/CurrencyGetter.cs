using Infrastructure.Entities;
using Infrastructure.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class CurrencyGetter
    {
        String UrlString = "https://www.tcmb.gov.tr/kurlar/today.xml";
        public Currencies GetCurrencies()
        {
            var deserializer = new XmlDeserializeHelper<Currencies>();
            var deserializeData = deserializer.XmlDeserialize(URLString);
            return deserializeData;

        }
        
        


        
    }
}
