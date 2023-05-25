using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHotel.Core.Entities;

namespace WebHotel.Data.Mappings
{
    public class RoomTypeMap : IEntityTypeConfiguration<RoomType>
    {
        public void Configure(EntityTypeBuilder<RoomType> builder)
        {
            builder.ToTable("RoomTypes");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name);
            builder.Property(t => t.Descriptions);
            builder.Property(t => t.isDelete);
            builder.Property(t => t.Create_At)
              .HasColumnType("datetime");
            builder.Property(t => t.Update_At)
             .HasColumnType("datetime");

        }
    }
}
