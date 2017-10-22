using System.Threading.Tasks;
using Abp.Application.Services;
using MeiLian.Configuration.Host.Dto;

namespace MeiLian.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
