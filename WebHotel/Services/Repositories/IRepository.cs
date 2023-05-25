
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHotel.Core.Contracts;
using WebHotel.Core.DTO;
using WebHotel.Core.Entities;

namespace WebHotel.Services.Repositories
{
    public interface IRepository
    {
        Task<IList<Room>> GetRoom(CancellationToken cancellationToken = default);
        Task<IList<Customer>> GetCustomer(CancellationToken cancellationToken = default);
        Task<IList<Employee>> GetEmployee(CancellationToken cancellationToken = default);
        Task<IList<Hotel>> GetHotel(CancellationToken cancellationToken = default);
        Task<IList<Folder>> GetFolder(CancellationToken cancellationToken = default);
        Task<IList<Filer>> GetFiler(CancellationToken cancellationToken = default);
        Task<IList<Service>> GetService(CancellationToken cancellationToken = default);
        Task<IList<Template>> GetTemplate(CancellationToken cancellationToken = default);
        Task<IList<Booking>> GetBooking(CancellationToken cancellationToken = default);
        Task<IPagedList<Room>> GetPagedRoomAsync(
         RoomQuery postQuery,
         int pageNumber = 1,
         int pageSize = 2,
         CancellationToken cancellationToken = default);
        Task<IPagedList<Service>> GetPagedServicesAsync(
        ServiceQuery condition,
        int pageNumber = 1,
        int pageSize = 2,
        CancellationToken cancellationToken = default);
        Task<IPagedList<Hotel>> GetPagedHotelsAsync(
        HotelQuery condition,
        int pageNumber = 1,
        int pageSize = 10,
        CancellationToken cancellationToken = default);
        Task<IPagedList<Template>> GetPagedTemplatesAsync(
        TemplateQuery condition,
        int pageNumber = 1,
        int pageSize = 10,
        CancellationToken cancellationToken = default);
        Task<IPagedList<Folder>> GetPagedFoldersAsync(
        FolderQuery condition,
        int pageNumber = 1,
        int pageSize = 10,
        CancellationToken cancellationToken = default);
        Task<IPagedList<Filer>> GetPagedFilersAsync(
        FilerQuery condition,
        int pageNumber = 1,
        int pageSize = 10,
        CancellationToken cancellationToken = default);
        Task<IPagedList<Customer>> GetPagedCustomersAsync(
        CustomerQuery condition,
        int pageNumber = 1,
        int pageSize = 10,
        CancellationToken cancellationToken = default);
        Task<IPagedList<Employee>> GetPagedEmployeesAsync(
        EmployeeQuery condition,
        int pageNumber = 1,
        int pageSize = 10,
        CancellationToken cancellationToken = default);
        Task<IPagedList<Booking>> GetPagedBookingsAsync(
        BookingQuery condition,
        int pageNumber = 1,
        int pageSize = 10,
        CancellationToken cancellationToken = default);
    }

}
