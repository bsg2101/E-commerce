using App.ArkaBahcemiz.Data.Repositories;
using App.ArkaBahcemiz.Models.DTOs;
using App.ArkaBahcemiz.Models.Entities;

namespace App.ArkaBahcemiz.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;
        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public Task<User> GetOrderByEmail(UserDTO userDTO)
        {
            var user = new User
            {
                Email = userDTO.Email,
                PasswordHashed = userDTO.Password
            };
            return _userRepository.GetUserByEmail(user);
           
        }
    }
}
