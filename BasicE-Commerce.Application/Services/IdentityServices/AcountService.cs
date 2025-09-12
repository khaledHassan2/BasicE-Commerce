using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.Application.IServices.IIdentityServices;
using BasicE_Commerce.DTOs.UserDTOs;
using BasicE_Commerce.Models;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicE_Commerce.Application.Services.IdentityServices
{
    public class AcountService : IAcountService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository _userRepository;

        public AcountService(IUnitOfWork unitOfWork, IUserRepository userRepository)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
        }

        public void Login(LoginUserDTO userDTO)
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public void Regitser(UserCreatedDTO userDTO)
        {
            if(userDTO.Name.Length > 3)
            {
                
                if (userDTO?.Email != null && userDTO?.Password != null)
                {
                    var user = userDTO.Adapt<User>();
                    _userRepository.Create(user);
                    _unitOfWork.Commit();
                }
            }
            else
            {

            }
        }
    }
}
