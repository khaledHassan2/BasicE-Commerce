using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.DTOs.OrderDTOs
{
    public class  OrderCreatedDTO
    {
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Pending";
       
 
        public int? UserId { get; set; }

    }
}
