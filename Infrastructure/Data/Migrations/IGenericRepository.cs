using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Migrations
{  
        public interface IGenericRepository<T> 
        {
            Task<T> GetByIdAsync(int id);
            Task<IReadOnlyList<T>> ListAllAsync();
            void Add(T entity);
            void Update(T entity);
            void Delete(T entity);
        }   
}
