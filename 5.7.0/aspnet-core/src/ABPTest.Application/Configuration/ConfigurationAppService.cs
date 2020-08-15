using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ABPTest.Configuration.Dto;

namespace ABPTest.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABPTestAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
