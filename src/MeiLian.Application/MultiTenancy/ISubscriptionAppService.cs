using System.Threading.Tasks;
using Abp.Application.Services;

namespace MeiLian.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task UpgradeTenantToEquivalentEdition(int upgradeEditionId);
    }
}
