// See https://aka.ms/new-console-template for more information

using WebHotel.Services.Repositories;
using WebHotel.Data.Contexts;
using WebHotel.Data.Seeders;

var context = new MyDbContext();

IRepository rp = new Repository(context);

var seeder = new DataSeeder(context);
seeder.Initialize();
var rooms = await rp.GetRoom();
var bookings = await rp.GetBooking();
var customers = await rp.GetCustomer();
var employees = await rp.GetEmployee();
var folders = await rp.GetFolder();
var filers = await rp.GetFiler();
var templates = await rp.GetTemplate();
var hotels = await rp.GetHotel();
var services = await rp.GetService();

Console.WriteLine("Danh sách phòng");
Console.WriteLine("-----------------------");
foreach (var room in rooms)
{
    Console.WriteLine(room.Name);
    Console.WriteLine(room.PriceManagement.Price);
    Console.WriteLine(room.Voucher.Discount);
    Console.WriteLine("-----------------------");
}
Console.WriteLine("Danh sách phòng đặt");
Console.WriteLine("-----------------------");
foreach (var booking in bookings)
{
    Console.WriteLine(booking.RoomName);
    Console.WriteLine(booking.UserName);
    Console.WriteLine("-----------------------");
}
Console.WriteLine("Danh sách Khách Hàng");
Console.WriteLine("-----------------------");
foreach (var customer in customers)
{
    Console.WriteLine(customer.Name);
    Console.WriteLine(customer.Phone);
    Console.WriteLine("-----------------------");
}

