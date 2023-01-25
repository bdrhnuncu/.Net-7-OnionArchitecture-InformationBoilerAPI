using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationBoilerAPI.Domain.Entities.Dto_s.UserDto_s
{
    public class UserDto
    {
        public int Id { get; set; }
        public int AddressId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfRegister { get; set; }
    }
}
