using System.Web;
using System.Web.Mvc;

namespace MVC_WebSite
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            // add Nudge Tracer (apm tool)
            //Nudge.APM.Tracer.Utils.InitByFilter(filters);
        }
    }
}
