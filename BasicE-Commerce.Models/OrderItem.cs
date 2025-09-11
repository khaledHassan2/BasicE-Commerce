using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.Models
{
    public  class OrderItem:BaseEntity<int>
    {
        public int Quantity {  get; set; }
        public double UnitPrice {  get; set; }
        [ForeignKey("order")]
        public int OrderID { get; set; }
        public ICollection<Order > orders { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public  ICollection <Product> Products { get; set; }
    }
}
