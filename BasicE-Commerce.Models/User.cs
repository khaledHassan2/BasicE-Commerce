using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.Models
{
    public class User:BaseEntity<int>
    {
        public string Name { get; set; } = null!;
        public string Email { get; set; }= null!;
        public string Password { get; set; } = null!;
        public string Role { get; set; } = "user";
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
