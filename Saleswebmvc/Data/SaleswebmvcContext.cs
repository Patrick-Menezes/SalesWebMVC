using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Saleswebmvc.Models;

namespace Saleswebmvc.Data
{
    public class SaleswebmvcContext : DbContext
    {
        public SaleswebmvcContext (DbContextOptions<SaleswebmvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; } = default!;
        public DbSet<Seller>Sellers { get; set; } 
        public DbSet<SallesRecord> SallesRecord { get; set; }




    }
}
