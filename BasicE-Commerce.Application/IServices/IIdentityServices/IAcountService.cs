using BasicE_Commerce.DTOs.UserDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.Application.IServices.IIdentityServices
{
    public interface IAcountService
    {
        public void Regitser(UserCreatedDTO userDTO);
        public bool Login(LoginUserDTO userDTO);
        public void Logout();
    }
}
