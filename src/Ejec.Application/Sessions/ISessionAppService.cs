using System.Threading.Tasks;
using Abp.Application.Services;
using Ejec.Sessions.Dto;

namespace Ejec.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
