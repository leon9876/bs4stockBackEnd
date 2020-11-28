using bs4stockBackEnd.Controllers;
using System.Web;
using System.Web.Mvc;

namespace bs4stockBackEnd
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new checkLoginStatus());
        }
    }
}
