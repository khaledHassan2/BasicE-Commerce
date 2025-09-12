using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.DTOs.CartItem
{
    public class CartItemCreatedDTO
    {
        public int Quantity { get; set; }
        public int CartID { get; set; }
       
        public int ProductId { get; set; }

    }
}
