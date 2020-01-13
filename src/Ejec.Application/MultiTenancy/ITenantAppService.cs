using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Ejec.MultiTenancy.Dto;

namespace Ejec.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

