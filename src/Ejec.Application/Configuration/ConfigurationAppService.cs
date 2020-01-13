using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Ejec.Configuration.Dto;

namespace Ejec.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : EjecAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
