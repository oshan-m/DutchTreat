﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutchTreat.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderNumber { get; set; }

        // Specifies the relationship to OderItems    
        public ICollection<OrderItem> Items { get; set; }
        public StoreUser User { get; set; }

    }
}
