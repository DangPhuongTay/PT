using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHotel.Core.Entities;
using WebHotel.Core.Contracts;

namespace WebHotel.Core.Entities
{
    public class Room : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }
        public bool isDelete { get; set; }
        public bool Status { get; set; }
        public int PriceId { get; set; }
        public int VoucherId { get; set; }
        public DateTime Create_At { get; set; }
        public DateTime? Update_At  { get; set; }
        public int RoomId { get; set; }
        public RoomType RoomType { get; set; }
        public Voucher Voucher { get; set; }
        public PriceManagement PriceManagement { get; set; }
    }
}
