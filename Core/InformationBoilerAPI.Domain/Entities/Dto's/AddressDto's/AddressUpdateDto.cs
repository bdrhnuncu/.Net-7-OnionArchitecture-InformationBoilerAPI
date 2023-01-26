using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationBoilerAPI.Domain.Entities.Dto_s.AddressDto_s
{
    public class AddressUpdateDto
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
}
