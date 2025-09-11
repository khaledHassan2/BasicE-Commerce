﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.Models
{
    public class Product:BaseEntity<int>
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int Stock {  get; set; }
        public decimal Price {  get; set; }
        public string? Image {  get; set; }
        public int CategoryId {  get; set; }
        public Category Category { get; set; } = null!;

        public ICollection<OrderItem> OrderItems { get; set; }= new List<OrderItem>();
        public ICollection<CartItem> CartItems { get; set; }= new List<CartItem>(); 

    }
}
