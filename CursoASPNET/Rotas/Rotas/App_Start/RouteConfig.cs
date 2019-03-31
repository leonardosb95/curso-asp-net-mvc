using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Rotas
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Quando eu digitar na URL, noticias/, vai mostrar todas as noticias para mim
            routes.MapRoute(
                name:" Todas as Noticias",
                url:"noticias/",
                defaults: new {controller= "Home", action = "TodasAsNoticias" }
                );


            //Quando eu digitar na URL, noticias/+ a categoria, vai exibir a categoria
            routes.MapRoute(
                name: " Categorias Especifica",
                url: "noticias/{categoria}",
                defaults: new { controller = "Home", action = "MostraCategoria" }
                );

            //Exibi a categoria/titulo+ o id, isso é bom para localizar rapidamente
            routes.MapRoute(
                name: " Mostra Noticia",
                url: "noticias/{categoria}/{titulo} - {noticiaId}",
                defaults: new { controller = "Home", action = "MostrarTodasAsNoticias" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
