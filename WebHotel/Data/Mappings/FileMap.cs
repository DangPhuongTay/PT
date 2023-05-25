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
    public class FilerMap : IEntityTypeConfiguration<Filer>
    {
        public void Configure(EntityTypeBuilder<Filer> builder)
        {
            builder.ToTable("Filers");
            builder.HasKey(v => v.Id);
            builder.Property(fd => fd.Name);
            builder.Property(fd => fd.Path);
            builder.Property(fd => fd.Size);
            builder.Property(fd => fd.Type);
            builder.Property(fd => fd.Create_At)
             .HasColumnType("datetime");
            builder.Property(fd => fd.Update_At)
             .HasColumnType("datetime");
        }
    }
}
