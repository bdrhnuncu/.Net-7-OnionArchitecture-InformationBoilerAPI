using AutoMapper;
using InformationBoilerAPI.Application.Abstract.Repositories;
using InformationBoilerAPI.Application.Abstract.Return_s;
using InformationBoilerAPI.Application.Abstract.Services;
using InformationBoilerAPI.Domain.Entities;
using InformationBoilerAPI.Domain.Entities.Dto_s.AddressDto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationBoilerAPI.Application.Concrete.Services
{
    public class AddressService : IAddressService
    {
        IAddressRepository _addressRepository;
        IMapper _mapper;
        public AddressService(IAddressRepository addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }

        public Task<IResult> Create(Address address)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(AddressUpdateDto addressUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
