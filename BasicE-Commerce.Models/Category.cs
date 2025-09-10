using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.Models
{
    public class Category : BaseEntity<int>
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; }
        public int OroductId {get; set;}
        public ICollection<Product> Products { get; set; } = new List<Product>();


    }
}
