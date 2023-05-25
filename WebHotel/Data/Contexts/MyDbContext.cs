using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHotel.Data.Mappings;
using WebHotel.Core.Entities;
using Microsoft.EntityFrameworkCore;


namespace WebHotel.Data.Contexts
{
    public class MyDbContext : DbContext
    {
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<PriceManagement> PriceManagements { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Folder> Folders { get; set; }
        public DbSet<Filer> Filers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-O2DJO0P;Database=WebHotelData;Trusted_Connection =True;MultipleActiveResultSets=true;Encrypt=False");
        //}
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public MyDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(RoomTypeMap).Assembly);
        }

    }
}
