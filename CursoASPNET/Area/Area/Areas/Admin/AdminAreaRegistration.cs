using System.Web.Mvc;

namespace Area.Areas.Admin
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
                //new { action = "Index", id = UrlParameter.Optional }
                new { controller = "Home",action="Index", id = UrlParameter.Optional }//Vai enttender que ja tem o controller Home como padrão, quando digitar na URl /admin, já aparece a pagina
            );
        }
    }
}