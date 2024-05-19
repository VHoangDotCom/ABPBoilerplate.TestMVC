using Abp.Application.Services;
using CompanyManagement.MultiTenancy.Dto;

namespace CompanyManagement.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

