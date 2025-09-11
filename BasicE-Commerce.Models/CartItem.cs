using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.Models
{
    public  class CartItem :BaseEntity<int>
    {
        public int Quantity{ get; set;}
        public int CartID{ get; set;}
        public Cart Cart{ get; set;}= null!;
        public int ProductId {  get; set;}  
        public Product Product { get; set; } = null!;

    }
}
