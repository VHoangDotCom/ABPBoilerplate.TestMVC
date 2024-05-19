using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using CompanyManagement.Configuration.Dto;

namespace CompanyManagement.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CompanyManagementAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
