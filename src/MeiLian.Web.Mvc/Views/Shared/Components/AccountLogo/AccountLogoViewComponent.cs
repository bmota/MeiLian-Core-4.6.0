using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MeiLian.Web.Session;

namespace MeiLian.Web.Views.Shared.Components.AccountLogo
{
    public class AccountLogoViewComponent : MeiLianViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AccountLogoViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var loginInfo = await _sessionCache.GetCurrentLoginInformationsAsync();
            return View(new AccountLogoViewModel(loginInfo));
        }
    }
}
