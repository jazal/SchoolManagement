using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Saho.SchoolManagementSystem.Configuration.Dto;

namespace Saho.SchoolManagementSystem.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SchoolManagementSystemAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
