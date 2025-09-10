using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class order:BaseEntity<int>
    {
       public DateOnly  OrderDate {  get; set; }
        public string Stutas { get; set; }
        [ForeignKey("OrderItem")]
        public int OrderItemId { get; set; }
        public OrderItem OrderItem { get; set; }
        [ForeignKey("Cart")]
        public  int CartId { get; set; }
        public Cart Cart { get; set; }



    }
}
