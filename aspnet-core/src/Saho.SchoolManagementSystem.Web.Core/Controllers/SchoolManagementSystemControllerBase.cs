using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Saho.SchoolManagementSystem.Controllers
{
    public abstract class SchoolManagementSystemControllerBase: AbpController
    {
        protected SchoolManagementSystemControllerBase()
        {
            LocalizationSourceName = SchoolManagementSystemConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
