using System.Threading.Tasks;
using Abp.Application.Services;
using Saho.SchoolManagementSystem.Authorization.Accounts.Dto;

namespace Saho.SchoolManagementSystem.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
