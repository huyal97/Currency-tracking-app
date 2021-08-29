using Infrastructure.Data.Migrations;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
      
            public class CurrencyRepository : ICurrencyRepository
            {
                private readonly ExchangeContext _context;
                public CurrencyRepository(ExchangeContext context)
                {
                    _context = context;
                }

                public Currencies GetByIdAsync(int id)
                {
                    return _context.Set<Currencies>().Find(id);
                }

                public Currencies ListAll()
                {          
                    return _context.Set<Currencies>().Include(r=>r.currencyList).OrderBy(r=>r.Id).Last();
                }

                public void Add(Currencies entity)
                {
                    _context.Set<Currencies>().Add(entity);
                    _context.SaveChanges();
                }
                public void Delete(Currencies entity)
                {
                    _context.Set<Currencies>().Remove(entity);
                }
                public void Update(Currencies entity)
                {
                    _context.Set<Currencies>().Attach(entity);
                    _context.Entry(entity).State = EntityState.Modified;
                }
        
    }
        
    
}
