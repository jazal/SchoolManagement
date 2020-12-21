using System.Threading.Tasks;
using Saho.SchoolManagementSystem.Models.TokenAuth;
using Saho.SchoolManagementSystem.Web.Controllers;
using Shouldly;
using Xunit;

namespace Saho.SchoolManagementSystem.Web.Tests.Controllers
{
    public class HomeController_Tests: SchoolManagementSystemWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}