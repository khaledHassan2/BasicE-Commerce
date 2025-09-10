using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public  class OrderItem:BaseEntity<int>
    {
        public int Quantity {  get; set; }
        public double UnitPrice {  get; set; }
        public int OrderID { get; set; }
        public ICollection<order > orders { get; set; }
        public int ProductID { get; set; }
        public  ICollection <Product> Products { get; set; }
    }
}
