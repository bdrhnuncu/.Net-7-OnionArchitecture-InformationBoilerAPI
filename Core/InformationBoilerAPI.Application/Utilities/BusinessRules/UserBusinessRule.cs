using InformationBoilerAPI.Application.Abstract.BusinessRules;
using InformationBoilerAPI.Application.Abstract.Repositories;
using InformationBoilerAPI.Application.Abstract.Return_s;
using InformationBoilerAPI.Domain.Entities;
using InformationBoilerAPI.Domain.Entities.Dto_s.UserDto_s;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using InformationBoilerAPI.Application.Utilities.Return_s;
using InformationBoilerAPI.Application.Utilities.Constant;

namespace InformationBoilerAPI.Application.Utilities.BusinessRules
{
    public class UserBusinessRule : IUserBusinessRule
    {
        IUserRepository _userRepository;
        public UserBusinessRule(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<IResult> CheckLogin(UserLoginDto userLoginDto)
        {
            //hash ile yapılacak
        }

        public async Task<IResult> CheckUser(string email, string phone)
        {
            var emailCheck = await _userRepository.Get(x => x.Email == email);
            if (emailCheck == null)
            {
                var phoneCheck = await _userRepository.Get(x => x.Phone == phone);
                return phoneCheck == null
                    ? new SuccessResult()
                    : new ErrorResult(ConstantMessage.PhoneExist);
            }
            return new ErrorResult(ConstantMessage.EmailExist);
        }
    }
}
