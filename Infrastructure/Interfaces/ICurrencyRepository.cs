using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Migrations
{  
        public interface ICurrencyRepository
        {
            Currencies GetByIdAsync(int id);

            Currencies ListAll();

            void Add(Currencies entity);

            void Update(Currencies entity);

            void Delete(Currencies entity);
        }   
}
