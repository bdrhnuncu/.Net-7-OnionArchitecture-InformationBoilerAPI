using AutoMapper;
using InformationBoilerAPI.Application.Abstract.BusinessRules;
using InformationBoilerAPI.Application.Abstract.Repositories;
using InformationBoilerAPI.Application.Abstract.Return_s;
using InformationBoilerAPI.Application.Abstract.Services;
using InformationBoilerAPI.Application.Utilities.Return_s;
using InformationBoilerAPI.Domain.Entities;
using InformationBoilerAPI.Domain.Entities.Dto_s.AddressDto_s;
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
        IAddressService _addressService;
        IUserRepository _userRepository;
        IMapper _mapper;
        IUserBusinessRule _userBusinessRule;
        public UserService(IAddressService addressService, IUserRepository userRepository, IMapper mapper, IUserBusinessRule userBusinessRule)
        {
            _addressService = addressService;
            _userRepository = userRepository;
            _mapper = mapper;
            _userBusinessRule = userBusinessRule;
        }

        public async Task<IResult> Create(UserCreateDto userCreateDto)
        {
            var businessRule = await _userBusinessRule.CheckUser(userCreateDto.Email, userCreateDto.Phone);
            if (businessRule.Success)
            {
                var mapUser = _mapper.Map<User>(userCreateDto);
                var mapAddress = _mapper.Map<Address>(userCreateDto);
                await _addressService.Create(mapAddress);
                mapUser.AddressId = mapAddress.Id;
                await _userRepository.Create(mapUser);
                return businessRule;
            }
            return businessRule;
        }

        public Task<IResult> Delete(UserDto userDto)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<List<UserDto>>> GetAll()
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
