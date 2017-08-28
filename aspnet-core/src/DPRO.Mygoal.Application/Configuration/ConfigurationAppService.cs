using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using DPRO.Mygoal.Configuration.Dto;

namespace DPRO.Mygoal.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MygoalAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
