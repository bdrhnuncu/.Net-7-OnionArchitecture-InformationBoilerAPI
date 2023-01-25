using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationBoilerAPI.Domain.Entities
{
    public class Roles
    {
        public string RoleBasic => "User";
        public string RolePremium => "PremiumUser";
        public string RoleSpecial => "Admin";
    }
}
