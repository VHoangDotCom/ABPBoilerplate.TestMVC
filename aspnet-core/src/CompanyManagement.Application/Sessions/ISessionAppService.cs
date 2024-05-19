using System.Threading.Tasks;
using Abp.Application.Services;
using CompanyManagement.Sessions.Dto;

namespace CompanyManagement.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
