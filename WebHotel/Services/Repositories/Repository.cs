
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHotel.Core.Contracts;
using WebHotel.Core.DTO;
using WebHotel.Core.Entities;
using WebHotel.Data.Contexts;
using WebHotel.Services.Extentions;

namespace WebHotel.Services.Repositories
{
    public class Repository:IRepository
    {
        private readonly MyDbContext _blogContext;
        public Repository(MyDbContext dbContext)
        {
            _blogContext = dbContext;

        }
        public async Task<IList<Room>> GetRoom(CancellationToken cancellationToken = default)
        {
           return await _blogContext.Set<Room>()
                .Include(x=>x.RoomType)
                .Include(x=>x.Voucher)
                .Include(x=>x.PriceManagement)
                .ToListAsync(cancellationToken);
        }
        public async Task<IList<Customer>> GetCustomer(CancellationToken cancellationToken = default)
        {
            return await _blogContext.Set<Customer>().ToListAsync(cancellationToken);
                 
        }
        public async Task<IList<Employee>> GetEmployee(CancellationToken cancellationToken = default)
        {
            return await _blogContext.Set<Employee>().ToListAsync(cancellationToken);

        }
        public async Task<IList<Hotel>> GetHotel(CancellationToken cancellationToken = default)
        {
            return await _blogContext.Set<Hotel>().ToListAsync(cancellationToken);

        }
        public async Task<IList<Folder>> GetFolder(CancellationToken cancellationToken = default)
        {
            return await _blogContext.Set<Folder>().ToListAsync(cancellationToken);

        }
        public async Task<IList<Filer>> GetFiler(CancellationToken cancellationToken = default)
        {
            return await _blogContext.Set<Filer>().ToListAsync(cancellationToken);

        }
        public async Task<IList<Service>> GetService(CancellationToken cancellationToken = default)
        {
            return await _blogContext.Set<Service>().ToListAsync(cancellationToken);

        }
        public async Task<IList<Template>> GetTemplate(CancellationToken cancellationToken = default)
        {
            return await _blogContext.Set<Template>().ToListAsync(cancellationToken);

        }
        public async Task<IList<Booking>> GetBooking(CancellationToken cancellationToken = default)
        {
            return await _blogContext.Set<Booking>().ToListAsync(cancellationToken);


        }


        //----------------Room---------------//
        public async Task<IPagedList<Room>> GetPagedRoomAsync(
          RoomQuery condition,
          int pageNumber = 1,
          int pageSize = 10,
          CancellationToken cancellationToken = default)
        {
            return await FilterPosts(condition).ToPagedListAsync(
                 pageNumber, pageSize,
                 nameof(Room.Create_At),"DESC",
                 cancellationToken);
        }
        private IQueryable<Room> FilterPosts(RoomQuery condition)
        {
            IQueryable<Room> rooms = _blogContext.Set<Room>()
                .Include(x => x.PriceManagement)
                .Include(x => x.Voucher)
                .Include(x => x.RoomType);

            if (!string.IsNullOrWhiteSpace(condition.Keyword))
            {
                rooms = rooms.Where(x => x.Name.Contains(condition.Keyword));
            }
            return rooms;

        }


        //----------------Service---------------//
        public async Task<IPagedList<Service>> GetPagedServicesAsync(
        ServiceQuery condition,
        int pageNumber = 1,
        int pageSize = 10,
        CancellationToken cancellationToken = default)
        {
            return await FilterServices(condition).ToPagedListAsync(
                 pageNumber, pageSize,
                 nameof(Service.Price), "DESC",
                 cancellationToken);
        }
        private IQueryable<Service> FilterServices(ServiceQuery condition)
        {
            IQueryable<Service> services = _blogContext.Set<Service>();
               

            if (!string.IsNullOrWhiteSpace(condition.Keyword))
            {
                services = services.Where(x => x.Name.Contains(condition.Keyword));
            }
            return services;

        }


        //----------------Hotel---------------//
        public async Task<IPagedList<Hotel>> GetPagedHotelsAsync(
       HotelQuery condition,
       int pageNumber = 1,
       int pageSize = 10,
       CancellationToken cancellationToken = default)
        {
            return await FilterHotels(condition).ToPagedListAsync(
                 pageNumber, pageSize,
                 nameof(Hotel.Name), "DESC",
                 cancellationToken);
        }
        private IQueryable<Hotel> FilterHotels(HotelQuery condition)
        {
            IQueryable<Hotel> hotels = _blogContext.Set<Hotel>();

            if (!string.IsNullOrWhiteSpace(condition.Keyword))
            {
                hotels = hotels.Where(x => x.Name.Contains(condition.Keyword));
            }
            return hotels;

        }

        //----------------Template---------------//
        public async Task<IPagedList<Template>> GetPagedTemplatesAsync(
       TemplateQuery condition,
       int pageNumber = 1,
       int pageSize = 10,
       CancellationToken cancellationToken = default)
        {
            return await FilterTemplates(condition).ToPagedListAsync(
                 pageNumber, pageSize,
                 nameof(Template.Name), "DESC",
                 cancellationToken);
        }
        private IQueryable<Template> FilterTemplates(TemplateQuery condition)
        {
            IQueryable<Template> templates = _blogContext.Set<Template>();

            if (!string.IsNullOrWhiteSpace(condition.Keyword))
            {
                templates = templates.Where(x => x.Name.Contains(condition.Keyword));
            }
            return templates;

        }

        //----------------Folder---------------//
        public async Task<IPagedList<Folder>> GetPagedFoldersAsync(
       FolderQuery condition,
       int pageNumber = 1,
       int pageSize = 10,
       CancellationToken cancellationToken = default)
        {
            return await FilterFolders(condition).ToPagedListAsync(
                 pageNumber, pageSize,
                 nameof(Folder.Name), "DESC",
                 cancellationToken);
        }
        private IQueryable<Folder> FilterFolders(FolderQuery condition)
        {
            IQueryable<Folder> folders = _blogContext.Set<Folder>();


            if (!string.IsNullOrWhiteSpace(condition.Keyword))
            {
                folders = folders.Where(x => x.Name.Contains(condition.Keyword));
            }
            return folders;

        }

        //----------------Filer---------------//
        public async Task<IPagedList<Filer>> GetPagedFilersAsync(
       FilerQuery condition,
       int pageNumber = 1,
       int pageSize = 10,
       CancellationToken cancellationToken = default)
        {
            return await FilterFilers(condition).ToPagedListAsync(
                 pageNumber, pageSize,
                 nameof(Filer.Name), "DESC",
                 cancellationToken);
        }
        private IQueryable<Filer> FilterFilers(FilerQuery condition)
        {
            IQueryable<Filer> filers = _blogContext.Set<Filer>();


            if (!string.IsNullOrWhiteSpace(condition.Keyword))
            {
                filers = filers.Where(x => x.Name.Contains(condition.Keyword));
            }
            return filers;

        }
        //----------------Employee---------------//
        public async Task<IPagedList<Employee>> GetPagedEmployeesAsync(
       EmployeeQuery condition,
       int pageNumber = 1,
       int pageSize = 10,
       CancellationToken cancellationToken = default)
        {
            return await FilterEmployees(condition).ToPagedListAsync(
                 pageNumber, pageSize,
                 nameof(Employee.Name), "DESC",
                 cancellationToken);
        }
        private IQueryable<Employee> FilterEmployees(EmployeeQuery condition)
        {
            IQueryable<Employee> employees = _blogContext.Set<Employee>();


            if (!string.IsNullOrWhiteSpace(condition.Keyword))
            {
                employees = employees.Where(x => x.Name.Contains(condition.Keyword));
            }
            return employees;

        }
        //----------------Customer---------------//
        public async Task<IPagedList<Customer>> GetPagedCustomersAsync(
       CustomerQuery condition,
       int pageNumber = 1,
       int pageSize = 10,
       CancellationToken cancellationToken = default)
        {
            return await FilterCustomers(condition).ToPagedListAsync(
                 pageNumber, pageSize,
                 nameof(Customer.Name), "DESC",
                 cancellationToken);
        }
        private IQueryable<Customer> FilterCustomers(CustomerQuery condition)
        {
            IQueryable<Customer> customers = _blogContext.Set<Customer>();


            if (!string.IsNullOrWhiteSpace(condition.Keyword))
            {
                customers = customers.Where(x => x.Name.Contains(condition.Keyword));
            }
            return customers;

        }
        //----------------Booking---------------//
        public async Task<IPagedList<Booking>> GetPagedBookingsAsync(
       BookingQuery condition,
       int pageNumber = 1,
       int pageSize = 10,
       CancellationToken cancellationToken = default)
        {
            return await FilterBookings(condition).ToPagedListAsync(
                 pageNumber, pageSize,
                 nameof(Booking.RoomName), "DESC",
                 cancellationToken);
        }
        private IQueryable<Booking> FilterBookings(BookingQuery condition)
        {
            IQueryable<Booking> bookings = _blogContext.Set<Booking>();


            if (!string.IsNullOrWhiteSpace(condition.Keyword))
            {
                bookings = bookings.Where(x => x.RoomName.Contains(condition.Keyword));
            }
           
            return bookings;

        }
        
    }
}
