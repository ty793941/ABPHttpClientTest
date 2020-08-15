using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ABPTest.Controllers
{
    public abstract class ABPTestControllerBase: AbpController
    {
        protected ABPTestControllerBase()
        {
            LocalizationSourceName = ABPTestConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
