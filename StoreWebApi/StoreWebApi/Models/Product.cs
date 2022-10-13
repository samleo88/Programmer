using System;
using System.Collections.Generic;

#nullable disable

namespace StoreWebApi.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
