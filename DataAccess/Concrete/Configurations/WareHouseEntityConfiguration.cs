using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Configurations
{
    public class WareHouseEntityConfiguration : IEntityTypeConfiguration<WareHouse>
    {
        public void Configure(EntityTypeBuilder<WareHouse> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(x => x.ProductId);
            builder.Property(x => x.Amount);
            builder.Property(x => x.IsReadyForSell);
        }
    }
}
