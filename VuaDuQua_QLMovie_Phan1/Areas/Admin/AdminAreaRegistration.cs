using System.Web.Mvc;

namespace VuaDuQua_QLMovie_Phan1.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", controller="Cinemas", id = UrlParameter.Optional },
                new[] { "VuaDuQua_QLMovie_Phan1.Areas.Admin.Controllers" }
            );
        }
    }
}