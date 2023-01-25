using InformationBoilerAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationBoilerAPI.Domain.Entities
{
    public class Address : IBaseEntity
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
