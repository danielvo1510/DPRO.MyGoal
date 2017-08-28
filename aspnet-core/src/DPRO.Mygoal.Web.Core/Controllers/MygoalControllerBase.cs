using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace DPRO.Mygoal.Controllers
{
    public abstract class MygoalControllerBase: AbpController
    {
        protected MygoalControllerBase()
        {
            LocalizationSourceName = MygoalConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}