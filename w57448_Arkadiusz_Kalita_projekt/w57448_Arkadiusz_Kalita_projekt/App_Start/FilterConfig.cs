using System.Web;
using System.Web.Mvc;

namespace w57448_Arkadiusz_Kalita_projekt
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
