using Abp.Authorization;
using DPRO.Mygoal.Authorization.Roles;
using DPRO.Mygoal.Authorization.Users;
using DPRO.Mygoal.MultiTenancy;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;

namespace DPRO.Mygoal.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<IdentityOptions> options, 
            SignInManager signInManager) 
            : base(options, signInManager)
        {
        }
    }
}