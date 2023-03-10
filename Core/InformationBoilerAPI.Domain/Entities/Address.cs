using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationBoilerAPI.Domain.Entities
{
    public class Address : BaseEntity
    {
        public string Country { get; set; }
        public string City { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
