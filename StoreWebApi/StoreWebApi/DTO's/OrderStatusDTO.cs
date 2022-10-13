using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreWebApi.DTO_s
{
    public class OrderStatusDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<CustomerOrderDTO> CustomerOrder { get; set; }
    }
}
