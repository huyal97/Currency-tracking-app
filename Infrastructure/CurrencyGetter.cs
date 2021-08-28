using Infrastructure.Data.Migrations;
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
        ICurrencyRepository _currencyRepository;
        public CurrencyGetter(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        public Currencies GetCurrencies()
        {
            var deserializer = new XmlDeserializeHelper<Currencies>();
            var deserializeData = deserializer.XmlDeserialize(UrlString);
            _currencyRepository.Add(deserializeData);
            return deserializeData;           
        }             
    }
}
