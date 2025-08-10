using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsStore.Core.Models.ProductM;
using SportsStore.DataAccess.Entities;

namespace SportsStore.DataAccess.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<OrderEntities>
    {
        public void Configure(EntityTypeBuilder<OrderEntities> builder)
        {
            builder.HasKey(b => b.Id);


            builder
                .HasMany(b => b.Products)
                .WithOne(p => p.Order);
        }
    }
}

