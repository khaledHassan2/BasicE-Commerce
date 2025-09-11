using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.Models
{
    public  class Cart: BaseEntity<int>
    {
        public DateOnly CreateAt { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
       public User user { get; set; }
        [ForeignKey("CartItem")]
        public int CartItemId { get; set; }
        public CartItem item { get; set; }
        [ForeignKey("order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }


    }
}
