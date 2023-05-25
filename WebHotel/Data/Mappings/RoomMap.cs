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
    public class RoomMap : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.ToTable("Rooms");
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Name);
            builder.Property(r => r.Image);
            builder.Property(r => r.Video);
            builder.Property(r => r.Status);
            builder.Property(r => r.PriceId);
            builder.Property(r => r.VoucherId);
            builder.Property(r => r.RoomId);
            builder.Property(t => t.Create_At)
             .HasColumnType("datetime");
            builder.Property(r   => r.Update_At)
             .HasColumnType("datetime");
            builder.Property(r => r.isDelete);

            builder.HasOne(r => r.RoomType)
             .WithMany(t => t.Rooms)
             .HasForeignKey(r => r.RoomId)
             .HasConstraintName("FK_Rooms_RoomType")
             .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(r => r.PriceManagement)
                .WithMany(a => a.Rooms)
                .HasForeignKey(r => r.PriceId)
                .HasConstraintName("FK_Rooms_PriceManagement")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(r => r.Voucher)
                .WithMany(v => v.Rooms)
                .HasForeignKey(r => r.VoucherId)
                .HasConstraintName("FK_Rooms_Voucher")
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
