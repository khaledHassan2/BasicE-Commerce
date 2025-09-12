﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.DTOs.PtoductDTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string? Image { get; set; }
        public int CategoryId { get; set; }
    }
}
