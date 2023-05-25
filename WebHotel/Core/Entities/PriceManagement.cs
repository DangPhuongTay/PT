using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHotel.Core.Contracts;

namespace WebHotel.Core.Entities
{
    public class PriceManagement : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public bool isDelete { get; set; }
        public DateTime? Create_At { get; set; }
        public DateTime? Update_At { get; set; }
        public IList<Room> Rooms { get; set; }
    }
}
