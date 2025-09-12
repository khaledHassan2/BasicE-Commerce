using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.DTOs.Cart
{
    public class CartCreatedDTO
    {
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Pending";
        public int CartId { get; set; }
    
        public int UserId { get; set; }
    
    }
}
