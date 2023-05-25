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
    public class BookingMap : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.ToTable("Bookings");
            builder.HasKey(v => v.Id);
            builder.Property(v => v.RoomName);
            builder.Property(v => v.UserName);
            builder.Property(v => v.Booking_Date)
             .HasColumnType("datetime");
            builder.Property(v => v.CheckOut_Date)
             .HasColumnType("datetime");
        }
    }
}
