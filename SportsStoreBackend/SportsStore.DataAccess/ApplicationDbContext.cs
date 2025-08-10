using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportsStore.DataAccess.Entities;

namespace SportsStore.DataAccess
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options) { }

        public DbSet<OrderEntities> Order { get; set; }

        public DbSet<ProductEntities> Product { get; set; }

    }
}
