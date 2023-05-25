using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebHotel.Core.Entities;

namespace WebHotel.Data.Mappings
{
    public class PriceManagementMap : IEntityTypeConfiguration<PriceManagement>
    {
        public void Configure(EntityTypeBuilder<PriceManagement> builder)
        {
            builder.ToTable("PriceManagements");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name);
            builder.Property(p => p.Price);
            builder.Property(p => p.isDelete);
            builder.Property(p => p.Create_At)
             .HasColumnType("datetime");
            builder.Property(p => p.Update_At)
             .HasColumnType("datetime");
        }
    }
}
