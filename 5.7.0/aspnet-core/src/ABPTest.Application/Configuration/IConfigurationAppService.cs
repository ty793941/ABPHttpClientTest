using System.Threading.Tasks;
using ABPTest.Configuration.Dto;

namespace ABPTest.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
