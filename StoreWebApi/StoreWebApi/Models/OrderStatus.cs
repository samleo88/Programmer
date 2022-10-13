﻿using System;
using System.Collections.Generic;

#nullable disable

namespace StoreWebApi.Models
{
    public partial class OrderStatus
    {
        public OrderStatus()
        {
            CustomerOrders = new HashSet<CustomerOrder>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CustomerOrder> CustomerOrders { get; set; }
    }
}
