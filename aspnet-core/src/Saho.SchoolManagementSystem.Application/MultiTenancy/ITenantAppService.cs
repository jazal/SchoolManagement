using Abp.Application.Services;
using Saho.SchoolManagementSystem.MultiTenancy.Dto;

namespace Saho.SchoolManagementSystem.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

