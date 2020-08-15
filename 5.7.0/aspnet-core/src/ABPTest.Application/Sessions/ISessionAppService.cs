using System.Threading.Tasks;
using Abp.Application.Services;
using ABPTest.Sessions.Dto;

namespace ABPTest.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
