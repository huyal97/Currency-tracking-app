using Infrastructure.Data.Migrations;
using Infrastructure.Entities;
using Infrastructure.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class CurrencyGetter : ICurrencyGetter
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

            foreach(var currency in deserializeData.currencyList)
            {
                if(currency.CurrencyCode == "USD")
                {
                    currency.Priority = 1;
                }
                else if(currency.CurrencyCode == "EUR")
                {
                    currency.Priority = 2;
                }
                else if (currency.CurrencyCode == "GBP")
                {
                    currency.Priority = 3;
                }
                else
                {
                    currency.Priority = 4;
                }
            }

            _currencyRepository.Add(deserializeData);
            return deserializeData;           
        }             
    }
}
