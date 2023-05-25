using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using WebHotel.Core.DTO;
using WebHotel.Services.Repositories;

namespace WebHotel.WebApp.Controllers
{
    public class BlogController : Controller
    {
        private readonly IRepository _Repository;

        public BlogController(IRepository Repository)
        {
            _Repository = Repository;
        }

        //--------------Room--------------//
        public async Task<IActionResult> Index(
       [FromQuery(Name = "k")] string keyword = null,
       [FromQuery(Name = "p")] int pageNumber = 1,
       [FromQuery(Name = "ps")] int pageSize = 3)
        {
            var roomQuery = new RoomQuery()
            {
                Keyword = keyword
            };
            var postsList = await _Repository
                .GetPagedRoomAsync(roomQuery, pageNumber, pageSize);

            ViewBag.RoomQuery = roomQuery;

            return View(postsList);
        }

        //--------------Service--------------//
        public async Task<IActionResult> Service(
       [FromQuery(Name = "k")] string keyword = null,
       [FromQuery(Name = "p")] int pageNumber = 1,
       [FromQuery(Name = "ps")] int pageSize = 2)
        {
            var serviceQuery = new ServiceQuery()
            {
                Keyword = keyword
            };
            var postsList = await _Repository
                .GetPagedServicesAsync(serviceQuery, pageNumber, pageSize);

            ViewBag.ServiceQuery = serviceQuery;

            return View(postsList);
        }

        //--------------Hotel--------------//
        public async Task<IActionResult> Hotel(
      [FromQuery(Name = "k")] string keyword = null,
      [FromQuery(Name = "p")] int pageNumber = 1,
      [FromQuery(Name = "ps")] int pageSize = 2)
        {
            var hotelQuery = new HotelQuery()
            {
                Keyword = keyword
            };
            var postsList = await _Repository
                .GetPagedHotelsAsync(hotelQuery, pageNumber, pageSize);

            ViewBag.HotelQuery = hotelQuery;

            return View(postsList);
        }

        //--------------Template--------------//
        public async Task<IActionResult> Template(
     [FromQuery(Name = "k")] string keyword = null,
     [FromQuery(Name = "p")] int pageNumber = 1,
     [FromQuery(Name = "ps")] int pageSize = 2)
        {
            var templateQuery = new TemplateQuery()
            {
                Keyword = keyword
            };
            var postsList = await _Repository
                .GetPagedTemplatesAsync(templateQuery, pageNumber, pageSize);

            ViewBag.TemplateQuery = templateQuery;

            return View(postsList);
        }

        //--------------Folder--------------//
        public async Task<IActionResult> Folder(
     [FromQuery(Name = "k")] string keyword = null,
     [FromQuery(Name = "p")] int pageNumber = 1,
     [FromQuery(Name = "ps")] int pageSize = 2)
        {
            var folderQuery = new FolderQuery()
            {
                Keyword = keyword
            };
            var postsList = await _Repository
                .GetPagedFoldersAsync(folderQuery, pageNumber, pageSize);

            ViewBag.FolderQuery = folderQuery;

            return View(postsList);
        }

        //--------------Filer--------------//
        public async Task<IActionResult> Filer(
     [FromQuery(Name = "k")] string keyword = null,
     [FromQuery(Name = "p")] int pageNumber = 1,
     [FromQuery(Name = "ps")] int pageSize = 2)
        {
            var filerQuery = new FilerQuery()
            {
                Keyword = keyword
            };
            var postsList = await _Repository
                .GetPagedFilersAsync(filerQuery, pageNumber, pageSize);

            ViewBag.FilerQuery = filerQuery;

            return View(postsList);
        }

        //--------------Customer--------------//
        public async Task<IActionResult> Customer(
     [FromQuery(Name = "k")] string keyword = null,
     [FromQuery(Name = "p")] int pageNumber = 1,
     [FromQuery(Name = "ps")] int pageSize = 2)
        {
            var customerQuery = new CustomerQuery()
            {
                Keyword = keyword
            };
            var postsList = await _Repository
                .GetPagedCustomersAsync(customerQuery, pageNumber, pageSize);

            ViewBag.CustomerQuery = customerQuery;

            return View(postsList);
        }

        //--------------Employee--------------//
        public async Task<IActionResult> Employee(
     [FromQuery(Name = "k")] string keyword = null,
     [FromQuery(Name = "p")] int pageNumber = 1,
     [FromQuery(Name = "ps")] int pageSize = 2)
        {
            var employeeQuery = new EmployeeQuery()
            {
                Keyword = keyword
            };
            var postsList = await _Repository
                .GetPagedEmployeesAsync(employeeQuery, pageNumber, pageSize);

            ViewBag.EmployeeQuery = employeeQuery;

            return View(postsList);
        }

        //--------------Booking--------------//
        public async Task<IActionResult> Booking(
     [FromQuery(Name = "k")] string keyword = null,
     [FromQuery(Name = "p")] int pageNumber = 1,
     [FromQuery(Name = "ps")] int pageSize = 10)
        {
            var bookingQuery = new BookingQuery()
            {
                Keyword = keyword
            };
            var postsList = await _Repository
                .GetPagedBookingsAsync(bookingQuery, pageNumber, pageSize);

            ViewBag.BookingQuery = bookingQuery;

            return View(postsList);
        }

    }
}
