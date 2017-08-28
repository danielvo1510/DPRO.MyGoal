using System.Threading.Tasks;
using Abp.Application.Services;
using DPRO.Mygoal.Authorization.Accounts.Dto;

namespace DPRO.Mygoal.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
