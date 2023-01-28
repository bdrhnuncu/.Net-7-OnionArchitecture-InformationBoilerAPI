using AutoMapper;
using InformationBoilerAPI.Domain.Entities;
using InformationBoilerAPI.Domain.Entities.Dto_s.UserDto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationBoilerAPI.Application.Utilities.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserCreateDto, User>().ReverseMap();
            CreateMap<UserCreateDto, Address>().ReverseMap()
                .ForMember(x => x.Country, z => z.MapFrom(y => y.Country))
                .ForMember(x => x.City, z => z.MapFrom(y => y.City));
            CreateMap<UserUpdateDto, User>().ReverseMap();
        }
    }
}
