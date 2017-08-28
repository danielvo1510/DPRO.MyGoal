using System.Threading.Tasks;
using Abp.Application.Services;
using DPRO.Mygoal.Sessions.Dto;

namespace DPRO.Mygoal.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
