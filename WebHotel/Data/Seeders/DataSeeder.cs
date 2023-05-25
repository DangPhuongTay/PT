using Azure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHotel.Core.Entities;
using WebHotel.Data.Contexts;


namespace WebHotel.Data.Seeders
{
    public class DataSeeder : IDataSeeder
    {
        private readonly MyDbContext _dbContext;

        public object roomtypes { get; private set; }

        public DataSeeder(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Initialize()
        {
            _dbContext.Database.EnsureCreated();
            if (_dbContext.Rooms.Any()) return;

            var bookings = AddBooking();
            var templates = AddTemplate();
            var services = AddService();
            var hotels = AddHotel();
            var folders = AddFolder();
            var filers = AddFiler();
            var employees = AddEmployee();
            var customers = AddCustomer();
            var priceManagements = AddPriceManagement();
            var vouchers = AddVoucher();
            var roomTypes = AddRoomType();
            var rooms = AddRoom(priceManagements, vouchers, roomTypes);



        }
        private IList<Booking> AddBooking()
        {

            var bookings = new List<Booking>()
            {
                new()
                {
                    RoomName = "Phòng A1",
                    UserName = "Khách Hành 1",
                    Booking_Date = new DateTime(2022, 10, 21),
                    CheckOut_Date = new DateTime(2022, 11, 21)
                },
                new()
                {
                    RoomName = "Phòng A2",
                    UserName = "Khách Hành 2",
                    Booking_Date = new DateTime(2022, 10, 21),
                    CheckOut_Date = new DateTime(2022, 11, 21)
                },
                new()
                {
                    RoomName = "Phòng A3",
                    UserName = "Khách Hành 3",
                    Booking_Date = new DateTime(2022, 10, 21),
                    CheckOut_Date = new DateTime(2022, 11, 21)
                }
            };
            _dbContext.Bookings.AddRange(bookings);
            _dbContext.SaveChanges();

            return bookings;
        }
        private IList<Customer> AddCustomer()
        {

            var customers = new List<Customer>()
            {
                new()
                {
                    Name = "Khách Hành 1",
                    IdCard = "01234567",
                    Phone = "0123456789"
                },
                new()
                {
                    Name = "Khách Hành 2",
                    IdCard = "01234567",
                    Phone = "0123456789"
                },
                new()
                {
                    Name = "Khách Hành 3",
                    IdCard = "01234567",
                    Phone = "0123456789"
                },
            };
            _dbContext.Customers.AddRange(customers);
            _dbContext.SaveChanges();

            return customers;
        }
        private IList<Employee> AddEmployee()
        {

            var employees = new List<Employee>()
            {
                new()
                {
                    Name = "Nhân Viên 1",
                    Address = "01,Phù Đổng Thiên Vương,p8,Tp.Đà Lạt",
                    Phone = "0123456789",
                    Email = "Nhanvien1@gmail.com",
                    Job = "Lễ Tân"
                },
                new()
                {
                    Name = "Nhân Viên 2",
                    Address = "01,Phù Đổng Thiên Vương,p8,Tp.Đà Lạt",
                    Phone = "0123456789",
                    Email = "Nhanvien2@gmail.com",
                    Job = "Lễ Tân"
                },
                new()
                {
                    Name = "Nhân Viên 3",
                    Address = "01,Phù Đổng Thiên Vương,p8,Tp.Đà Lạt",
                    Phone = "0123456789",
                    Email = "Nhanvien3@gmail.com",
                    Job = "Lễ Tân"
                },
            };
            _dbContext.Employees.AddRange(employees);
            _dbContext.SaveChanges();

            return employees;
        }
        private IList<Filer> AddFiler()
        {

            var filers = new List<Filer>()
            {
                new()
                {
                    Name = "Filer 1",
                    Path = "src/nhom1/folder1",
                    Size = 100,
                    Type = "docx",
                    Create_At = new DateTime(2022, 10, 21),
                    Update_At = new DateTime(2022, 10, 24)
                },
                new()
                {
                    Name = "Filer 2",
                    Path = "src/nhom2/folder2",
                    Size = 100,
                    Type = "docx",
                    Create_At = new DateTime(2022, 10, 21),
                    Update_At = new DateTime(2022, 10, 24)
                },
                new()
                {
                    Name = "Filer 3",
                    Path = "src/nhom3/folder3",
                    Size = 100,
                    Type = "docx",
                    Create_At = new DateTime(2022, 10, 21),
                    Update_At = new DateTime(2022, 10, 24)
                },
            };
            _dbContext.Filers.AddRange(filers);
            _dbContext.SaveChanges();

            return filers;
        }
        private IList<Folder> AddFolder()
        {

            var folders = new List<Folder>()
            {
                new()
                {
                    Name = "Folder 1",
                    Path = "src/nhom1",
                    Size = 1000,
                    Create_At = new DateTime(2022, 10, 21),
                    Update_At = new DateTime(2022, 10, 24)
                },
                 new()
                {
                    Name = "Folder 2",
                    Path = "src/nhom2",
                    Size = 1000,
                    Create_At = new DateTime(2022, 10, 21),
                    Update_At = new DateTime(2022, 10, 24)
                },
                  new()
                {
                    Name = "Folder 3",
                    Path = "src/nhom3",
                    Size = 1000,
                    Create_At = new DateTime(2022, 10, 21),
                    Update_At = new DateTime(2022, 10, 24)
                },
            };
            _dbContext.Folders.AddRange(folders);
            _dbContext.SaveChanges();

            return folders;
        }
        private IList<Hotel> AddHotel()
        {

            var hotels = new List<Hotel>()
            {
                new()
                {
                    Name = "Khách Sạn 1",
                    Image = "https://picsum.photos/200",
                    Type = "3",
                    Address = "01,Phù Đổng Thiên Vương,p8,Tp.Đà Lạt",
                    Phone = "0123456789"
                },
                new()
                {
                    Name = "Khách Sạn 2",
                    Image = "https://picsum.photos/200",
                    Type = "4",
                    Address = "01,Phù Đổng Thiên Vương,p8,Tp.Đà Lạt",
                    Phone = "0123456789"
                },
                new()
                {
                    Name = "Khách Sạn 3",
                    Image = "https://picsum.photos/200",
                    Type = "5",
                    Address = "01,Phù Đổng Thiên Vương,p8,Tp.Đà Lạt",
                    Phone = "0123456789"
                }
            };
            _dbContext.Hotels.AddRange(hotels);
            _dbContext.SaveChanges();

            return hotels;
        }
        private IList<PriceManagement> AddPriceManagement()
        {

            var priceManagements = new List<PriceManagement>()
            {
                new()
                {
                    Name = "Đơn Giá 1",
                    Price = "100000",
                    isDelete = false,
                    Create_At = new DateTime(2022, 10, 21),
                    Update_At = new DateTime(2022, 10, 24)
                },
                new()
                {
                    Name = "Đơn Giá 2",
                    Price = "200000",
                    isDelete = false,
                    Create_At = new DateTime(2022, 10, 21),
                    Update_At = new DateTime(2022, 10, 24)
                },
                new()
                {
                    Name = "Đơn Giá 3",
                    Price = "300000",
                    isDelete = false,
                    Create_At = new DateTime(2022, 10, 21),
                    Update_At = new DateTime(2022, 10, 24)
                },

            };
            _dbContext.PriceManagements.AddRange(priceManagements);
            _dbContext.SaveChanges();

            return priceManagements;
        }

        private IList<RoomType> AddRoomType()
        {

            var roomTypes = new List<RoomType>()
            {
                new()
                {
                    Name = "Đơn",
                    Descriptions = "1 dường đơn",
                    isDelete = false,
                    Create_At = new DateTime(2022, 10, 21),
                    Update_At = new DateTime(2022, 10, 24)
                },
                 new()
                {
                    Name = "Đôi",
                    Descriptions = "2 dường đơn",
                    isDelete = false,
                    Create_At = new DateTime(2022, 10, 21),
                    Update_At = new DateTime(2022, 10, 24)
                },
                  new()
                {
                    Name = "Ba",
                    Descriptions = "1 dường đơn, 1 dường đôi",
                    isDelete = false,
                    Create_At = new DateTime(2022, 10, 21),
                    Update_At = new DateTime(2022, 10, 24)
                },
            };
            _dbContext.RoomTypes.AddRange(roomTypes);
            _dbContext.SaveChanges();

            return roomTypes;
        }
        private IList<Voucher> AddVoucher()
        {

            var vouchers = new List<Voucher>()
            {
                new()
                {
                    Name = "Voucher 1",
                    Discount = "10",
                    isDelete = false,
                    Create_At = new DateTime(2022, 10, 21),
                    Update_At = new DateTime(2022, 10, 24)
                },
                new()
                {
                    Name = "Voucher 2",
                    Discount = "20",
                    isDelete = false,
                    Create_At = new DateTime(2022, 10, 21),
                    Update_At = new DateTime(2022, 10, 24)
                },
                new()
                {
                    Name = "Voucher 3",
                    Discount = "30",
                    isDelete = false,
                    Create_At = new DateTime(2022, 10, 21),
                    Update_At = new DateTime(2022, 10, 24)
                },
            };
            _dbContext.Vouchers.AddRange(vouchers);
            _dbContext.SaveChanges();

            return vouchers;
        }
        private IList<Service> AddService()
        {

            var services = new List<Service>()
            {
                new()
                {
                    Name = "Dịch Vụ 1",
                    Unit = "lần",
                    Price = "100000"
                },
                 new()
                {
                    Name = "Dịch Vụ 2",
                    Unit = "lần",
                    Price = "200000"
                },
                  new()
                {
                    Name = "Dịch Vụ 3",
                    Unit = "lần",
                    Price = "300000"
                },
            };
            _dbContext.Services.AddRange(services);
            _dbContext.SaveChanges();

            return services;
        }
        private IList<Template> AddTemplate()
        {

            var templates = new List<Template>()
            {
                new()
                {
                    Name = "Template 1",
                    Image = "https://picsum.photos/200"
                },
                new()
                {
                    Name = "Template 2",
                    Image = "https://picsum.photos/200"
                },
                new()
                {
                    Name = "Template 3",
                    Image = "https://picsum.photos/200"
                },
            };
            _dbContext.Templates.AddRange(templates);
            _dbContext.SaveChanges();

            return templates;
        }
        private IList<Room> AddRoom(
        IList<PriceManagement> priceManagements,
        IList<Voucher> vouchers,
        IList<RoomType> roomTypes)
        {

            var rooms = new List<Room>()
            {
                new()
                {
                    Name = "Phòng A1",
                    Image = "https://picsum.photos/200",
                    Video = "https://picsum.photos/300",
                    isDelete = false,
                    Status = true,
                    PriceManagement = priceManagements[0],
                    Voucher = vouchers[0],
                    RoomType = roomTypes[0],
                    Create_At = new DateTime(2022, 10, 21),
                    Update_At = new DateTime(2022, 10, 24)
                },
                new()
                {
                    Name = "Phòng A2",
                    Image = "https://picsum.photos/200",
                    Video = "https://picsum.photos/300",
                    isDelete = false,
                    Status = true,
                    PriceManagement = priceManagements[1],
                    Voucher = vouchers[1],
                    RoomType = roomTypes[1],
                    Create_At = new DateTime(2022, 10, 21),
                    Update_At = new DateTime(2022, 10, 24)
                },
                new()
                {
                    Name = "Phòng A3",
                    Image = "https://picsum.photos/200",
                    Video = "https://picsum.photos/300",
                    isDelete = false,
                    Status = true,
                    PriceManagement = priceManagements[2],
                    Voucher = vouchers[2],
                    RoomType = roomTypes[2],
                    Create_At = new DateTime(2022, 10, 21),
                    Update_At = new DateTime(2022, 10, 24)
                },

            };
            _dbContext.Rooms.AddRange(rooms);
            _dbContext.SaveChanges();

            return rooms;
        }

    }
}
