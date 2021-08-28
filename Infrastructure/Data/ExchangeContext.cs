using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    class ExchangeContext : DbContext
    {
        public ExchangeContext(DbContextOptions<ExchangeContext> options) : base(options)
        {
            
        }
        public DbSet<Currencies> Currencies { get; set; }
        public DbSet<Currencies> Currency { get; set; }
    }
}
