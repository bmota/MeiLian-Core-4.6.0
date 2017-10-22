using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace MeiLian.Web.Views
{
    public abstract class AbpZeroTemplateRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected AbpZeroTemplateRazorPage()
        {
            LocalizationSourceName = AbpZeroTemplateConsts.LocalizationSourceName;
        }
    }
}
