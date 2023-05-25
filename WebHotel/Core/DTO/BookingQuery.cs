using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHotel.Core.DTO
{
    public class BookingQuery
    {
       public string Keyword { get; set; }
       public string UserName { get; set; }
       public string RoomName { get; set; }
    }
}
