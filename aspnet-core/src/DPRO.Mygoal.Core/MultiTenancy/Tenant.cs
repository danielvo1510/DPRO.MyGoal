using Abp.MultiTenancy;
using DPRO.Mygoal.Authorization.Users;

namespace DPRO.Mygoal.MultiTenancy
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