using System.Threading.Tasks;
using Abp.Application.Services;
using Ejec.Authorization.Accounts.Dto;

namespace Ejec.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
