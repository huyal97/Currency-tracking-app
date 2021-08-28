using Infrastructure.Data.Migrations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
      
            public class GenericRepository<T> : IGenericRepository<T> where T : class
            {
                private readonly ExchangeContext _context;
                public GenericRepository(ExchangeContext context)
                {
                    _context = context;
                }

                public async Task<T> GetByIdAsync(int id)
                {
                    return await _context.Set<T>().FindAsync(id);
                }

                public async Task<IReadOnlyList<T>> ListAllAsync()
                {
                    return await _context.Set<T>().ToListAsync();
                }

                public void Add(T entity)
                {
                    _context.Set<T>().Add(entity);
            _context.SaveChanges();
                }
                public void Delete(T entity)
                {
                    _context.Set<T>().Remove(entity);
                }
                public void Update(T entity)
                {
                    _context.Set<T>().Attach(entity);
                    _context.Entry(entity).State = EntityState.Modified;
                }
            }
        
    
}
