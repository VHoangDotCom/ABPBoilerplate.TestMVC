using System.Threading.Tasks;
using CompanyManagement.Models.TokenAuth;
using CompanyManagement.Web.Controllers;
using Shouldly;
using Xunit;

namespace CompanyManagement.Web.Tests.Controllers
{
    public class HomeController_Tests: CompanyManagementWebTestBase
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