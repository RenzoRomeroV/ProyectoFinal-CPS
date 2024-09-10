using System.Web;
using System.Web.Mvc;

namespace Capa_MVC_TiendaUser
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
