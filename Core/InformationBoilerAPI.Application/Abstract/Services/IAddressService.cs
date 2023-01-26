using InformationBoilerAPI.Application.Abstract.Return_s;
using InformationBoilerAPI.Domain.Entities;
using InformationBoilerAPI.Domain.Entities.Dto_s.AddressDto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationBoilerAPI.Application.Abstract.Services
{
    public interface IAddressService
    {
        Task<IResult> Create(Address address);
        Task<IResult> Update(AddressUpdateDto addressUpdateDto);
    }
}
