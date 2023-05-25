using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHotel.Core.Contracts;

namespace WebHotel.Core.Entities
{
    public class Booking : IEntity
    {
        public int Id { get; set; }
        public string RoomName { get; set; }
        public string UserName { get; set; }
        public DateTime? Booking_Date { get; set; }
        public DateTime? CheckOut_Date { get; set; }
    }
}
