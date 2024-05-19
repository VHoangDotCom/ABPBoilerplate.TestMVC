using System.Threading.Tasks;
using CompanyManagement.Configuration.Dto;

namespace CompanyManagement.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
