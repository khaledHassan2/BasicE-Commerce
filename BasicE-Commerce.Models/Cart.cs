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

        public DateTime CreateAt { get; set; }= DateTime.Now;
        public int UserId { get; set; }
        public User User { get; set; }= null!;
        public ICollection<CartItem>? CartItems { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}
