using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Saho.SchoolManagementSystem.Roles.Dto;
using Saho.SchoolManagementSystem.Users.Dto;

namespace Saho.SchoolManagementSystem.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
