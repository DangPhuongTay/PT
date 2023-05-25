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
    public class HotelMap : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.ToTable("Hotels");
            builder.HasKey(ht => ht.Id);
            builder.Property(ht => ht.Name);
            builder.Property(ht => ht.Image);
            builder.Property(ht => ht.Type);
            builder.Property(ht => ht.Address);
            builder.Property(ht => ht.Phone);
        }
    }
}
