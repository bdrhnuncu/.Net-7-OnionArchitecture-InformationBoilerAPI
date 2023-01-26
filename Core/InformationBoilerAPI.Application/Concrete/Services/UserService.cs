using AutoMapper;
using InformationBoilerAPI.Application.Abstract.Repositories;
using InformationBoilerAPI.Application.Abstract.Return_s;
using InformationBoilerAPI.Application.Abstract.Services;
using InformationBoilerAPI.Domain.Entities.Dto_s.UserDto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationBoilerAPI.Application.Concrete.Services
{
    public class UserService : IUserService
    {
        IUserRepository _userRepository;
        IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public Task<IResult> Create(UserCreateDto userCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Delete(UserDto userDto)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<IEnumerable<UserDto>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<List<UserDto>>> GetAllOrderByRegisterDate()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<UserDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<string>> Login(UserLoginDto userLoginDto)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(UserUpdateDto userUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
