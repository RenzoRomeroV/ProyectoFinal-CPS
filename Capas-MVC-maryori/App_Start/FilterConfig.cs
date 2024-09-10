using System.Web;
using System.Web.Mvc;

namespace Capas_MVC_maryori
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
