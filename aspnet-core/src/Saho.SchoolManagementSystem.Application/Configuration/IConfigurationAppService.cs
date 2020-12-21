using System.Threading.Tasks;
using Saho.SchoolManagementSystem.Configuration.Dto;

namespace Saho.SchoolManagementSystem.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
