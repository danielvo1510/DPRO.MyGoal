using System.Threading.Tasks;
using DPRO.Mygoal.Configuration.Dto;

namespace DPRO.Mygoal.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}