using InformationBoilerAPI.Application.Abstract.Repositories;
using InformationBoilerAPI.Domain.Entities;
using InformationBoilerAPI.Persistence.Concrete.DbContext_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationBoilerAPI.Persistence.Repositories
{
    public class AddressRepository : BaseRepository<Address, PostgreSqlDbContext>, IAddressRepository
    {

    }
}
