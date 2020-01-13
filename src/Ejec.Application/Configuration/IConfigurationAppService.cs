using System.Threading.Tasks;
using Ejec.Configuration.Dto;

namespace Ejec.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
