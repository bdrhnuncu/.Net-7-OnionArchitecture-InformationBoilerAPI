using InformationBoilerAPI.Domain.Entities;
using InformationBoilerAPI.Domain.Entities.Dto_s.UserDto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationBoilerAPI.Application.Abstract.BusinessRules
{
    public interface IUserBusinessRule
    {
        Task<bool> CheckUser(UserCreateDto user);
        Task<bool> CheckLogin(UserLoginDto userLoginDto);
    }
}
