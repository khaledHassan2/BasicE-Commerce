using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public  class CartItem :BaseEntity<int>
    {
        public int Quantity{ get; set;}
        [ForeignKey("Cart")]
        public int CartID{ get; set;}
        public Cart Cart{ get; set;}
        [ForeignKey("Product")]
        public int ProductId {  get; set;}
        public  ICollection <Product> products { get; set;}


    }
}
