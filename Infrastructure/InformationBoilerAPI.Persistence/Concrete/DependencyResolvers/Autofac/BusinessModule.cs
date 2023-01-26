using Autofac;
using InformationBoilerAPI.Application.Abstract.Repositories;
using InformationBoilerAPI.Application.Abstract.Services;
using InformationBoilerAPI.Application.Concrete.Services;
using InformationBoilerAPI.Persistence.Concrete.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationBoilerAPI.Persistence.Concrete.DependencyResolvers.Autofac
{
    public class BusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<IUserRepository>().As<UserRepository>();
            builder.RegisterType<IAddressRepository>().As<AddressRepository>();
            builder.RegisterType<IUserService>().As<UserService>();
            builder.RegisterType<IAddressService>().As<AddressService>();
        }
    }
}
