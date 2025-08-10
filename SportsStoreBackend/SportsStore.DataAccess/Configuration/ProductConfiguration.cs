using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsStore.DataAccess.Entities;

namespace SportsStore.DataAccess.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<ProductEntities>
    {
        public void Configure(EntityTypeBuilder<ProductEntities> builder)
        {
            builder.HasKey(b => b.Id);


            builder
                .HasOne(p => p.Order)
                .WithMany(o => o.Products);
        }

    }
}

