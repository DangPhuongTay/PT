using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHotel.Core.Contracts;

namespace WebHotel.Core.Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IdCard { get; set; }
        public string Phone { get; set; }
    }
}
