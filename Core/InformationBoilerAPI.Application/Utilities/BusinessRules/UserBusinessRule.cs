using InformationBoilerAPI.Application.Abstract.BusinessRules;
using InformationBoilerAPI.Application.Abstract.Repositories;
using InformationBoilerAPI.Domain.Entities;
using InformationBoilerAPI.Domain.Entities.Dto_s.UserDto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationBoilerAPI.Application.Utilities.BusinessRules
{
    public class UserBusinessRule : IUserBusinessRule
    {
        IUserRepository _userRepository;
        public UserBusinessRule(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<bool> CheckLogin(UserLoginDto userLoginDto)
        {
            //hash ile yapılacak
        }

        public async Task<bool> CheckUser(UserCreateDto user)
        {
            var check = await _userRepository.GetAll(x=>x.Email==user.)
        }
    }
}
