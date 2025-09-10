using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Product:BaseEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
      public int Stock {  get; set; }
        [ForeignKey("Category")]
        public int CategotyId {  get; set; }
        public Category catogry { get; set; }
        [ForeignKey("OrderItem")]
        public int ItemOrderId {  get; set; }
        public OrderItem item { get; set; }
        [ForeignKey("Category")]
        public int  CategoryId {  get; set; }
        public Category Category { get; set; }



    }
}
