using BasicE_Commerce.Application.Contacts;
using BasicE_Commerce.Application.IServices.IIdentityServices;
using BasicE_Commerce.DTOs.UserDTOs;
using BasicE_Commerce.Models;
using Helpers;
using Mapster;

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

        public bool Login(LoginUserDTO userDTO)
        {
            if (userDTO != null && userDTO.Password !=null)
            {
                var user = _userRepository.GetItem(filter : e =>e.Email == userDTO.Email);
                if (user != null )
                {
                    if(userDTO.Password  == user.Password)
                    {
                        UserCookies.SaveCurrentUser(user.Id, user.Name,user.Email ,user.Password,user.Role);
                        return true;
                    }
                }
            }
            return false;

        }

        public void Logout()
        {
            UserCookies.RemoveCurrentUser();
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
