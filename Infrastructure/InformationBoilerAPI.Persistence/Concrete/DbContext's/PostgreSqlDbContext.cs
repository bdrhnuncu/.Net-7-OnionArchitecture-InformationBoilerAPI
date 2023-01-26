using InformationBoilerAPI.Domain.Entities;
using InformationBoilerAPI.Persistence.Concrete.Configuration;
using InformationBoilerAPI.Persistence.Concrete.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InformationBoilerAPI.Persistence.Concrete.DbContext_s
{
    public class PostgreSqlDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConnStringConfig.PostgreSqlConnString);
        }
        
    }
}
