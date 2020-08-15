using System.Threading.Tasks;
using ABPTest.Models.TokenAuth;
using ABPTest.Web.Controllers;
using Shouldly;
using Xunit;

namespace ABPTest.Web.Tests.Controllers
{
    public class HomeController_Tests: ABPTestWebTestBase
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