using Abp.MultiTenancy;
using Dychar.Dyadmin.Authorization.Users;

namespace Dychar.Dyadmin.MultiTenancy
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
