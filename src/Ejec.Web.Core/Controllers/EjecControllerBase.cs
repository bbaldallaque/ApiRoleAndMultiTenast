using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Ejec.Controllers
{
    public abstract class EjecControllerBase: AbpController
    {
        protected EjecControllerBase()
        {
            LocalizationSourceName = EjecConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
