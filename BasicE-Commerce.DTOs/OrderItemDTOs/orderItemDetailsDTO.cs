﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.DTOs.OrderItemDTOs
{
    public class orderItemDetailsDTO
    {
        public int? Id { get; set; }
        public int? Quantity { get; set; }
        //public decimal UnitPrice { get; set; }
        public string? ProductName { get; set; }
        public string? Description { get; set; }
        public int? Stock { get; set; }
        public decimal? Price { get; set; }



    }
}
