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

        public DbSet<Saleswebmvc.Models.Department> Department { get; set; } = default!;
    }
}
