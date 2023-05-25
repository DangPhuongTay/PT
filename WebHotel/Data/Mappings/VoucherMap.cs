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
    public class VoucherMap : IEntityTypeConfiguration<Voucher>
    {
        public void Configure(EntityTypeBuilder<Voucher> builder)
        {
            builder.ToTable("Vouchers");
            builder.HasKey(v => v.Id);
            builder.Property(v => v.Name);
            builder.Property(v => v.Discount);
            builder.Property(v => v.isDelete);
            builder.Property(v => v.Create_At)
             .HasColumnType("datetime");
            builder.Property(v => v.Update_At)
             .HasColumnType("datetime");
        }
    }
}
