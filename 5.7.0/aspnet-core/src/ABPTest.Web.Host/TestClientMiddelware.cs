using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ABPTest.Web.Host
{
    public class TestClientMiddelware : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // write something othersgit
            return await base.SendAsync(request, cancellationToken);
        }
    }
}
