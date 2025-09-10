using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User:BaseEntity<int>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string Role { get; set; }
        [ForeignKey("Cart")]
        public int? CartId { get; set; }
        public ICollection<Cart> Carts { get; set; }
        [ForeignKey("Order")]
        public int ? orderId { get; set; }
        public ICollection<order> Orders { get; set; }


    }
}
