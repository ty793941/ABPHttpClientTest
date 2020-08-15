using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp;
using Abp.Extensions;
using Abp.Notifications;
using Abp.Timing;
using Abp.Web.Security.AntiForgery;
using ABPTest.Controllers;

namespace ABPTest.Web.Host.Controllers
{
    public class HomeController : ABPTestControllerBase
    {
        private readonly TestClient _testClient;

        public HomeController( TestClient testClient)
        {
            _testClient = testClient;
        }

        public async Task<string> TestHttpClient()
        {
            return await _testClient.GetTest("https://www.baidu.com");
        }
    }
}
