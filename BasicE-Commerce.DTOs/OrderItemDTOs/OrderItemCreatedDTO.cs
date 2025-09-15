﻿using BasicE_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.DTOs.OrderItemDTOs
{
    public class OrderItemCreatedDTO
    {
        public int Quantity { get; set; }
        
        public int ProductId { get; set; }

        public int OrderId { get; set; }

    }
}
