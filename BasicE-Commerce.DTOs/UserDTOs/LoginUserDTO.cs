using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.DTOs.UserDTOs
{
    public class LoginUserDTO 
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
