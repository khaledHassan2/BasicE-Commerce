using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.Models
{
    public class Order : BaseEntity<int>
    {
        public DateTime  OrderDate {  get; set; }
        public string Status { get; set; } = "Pending";
        public int CartId { get; set; }
        public Cart Cart { get; set; } = null!;
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
