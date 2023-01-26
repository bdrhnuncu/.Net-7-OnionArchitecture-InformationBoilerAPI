using InformationBoilerAPI.Application.Abstract.Return_s;
using InformationBoilerAPI.Domain.Entities.Dto_s.UserDto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InformationBoilerAPI.Application.Abstract.Services
{
    public interface IUserService
    {
        Task<IResult> Create(UserCreateDto userCreateDto);
        Task<IResult> Update(UserUpdateDto userUpdateDto);
        Task<IResult> Delete(UserDto userDto);
        Task<IDataResult<UserDto>> GetById(int id);
        Task<IDataResult<IEnumerable<UserDto>>> GetAll();
        Task<IDataResult<IEnumerable<UserDto>>> GetAllOrderByRegisterDate();
        Task<IDataResult<string>> Login(UserLoginDto userLoginDto);//string because we will return jwt token...
    }
}
