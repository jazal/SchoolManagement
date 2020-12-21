using Abp.MultiTenancy;
using Saho.SchoolManagementSystem.Authorization.Users;

namespace Saho.SchoolManagementSystem.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
