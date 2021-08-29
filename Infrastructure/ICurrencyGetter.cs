using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public interface ICurrencyGetter
    {
        public Currencies GetCurrencies();
    }
}
