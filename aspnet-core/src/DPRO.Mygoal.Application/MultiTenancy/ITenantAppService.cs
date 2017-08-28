using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DPRO.Mygoal.MultiTenancy.Dto;

namespace DPRO.Mygoal.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
