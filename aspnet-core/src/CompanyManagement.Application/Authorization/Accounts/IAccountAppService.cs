using System.Threading.Tasks;
using Abp.Application.Services;
using CompanyManagement.Authorization.Accounts.Dto;

namespace CompanyManagement.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
