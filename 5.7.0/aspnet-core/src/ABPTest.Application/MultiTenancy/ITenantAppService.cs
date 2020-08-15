using Abp.Application.Services;
using ABPTest.MultiTenancy.Dto;

namespace ABPTest.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

