using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

/// <summary>
/// Desde 1979 existe o padrão de projeto MVC
/// Um padrão de projeto é uma forma ELEGANTE e CONCEITUADA  de organizar o código e montar o projeto
/// Esse padrão foi criado na linguagem SMALLTALK
/// 
/// MVC - MODEL VIEW CONTROLLER (termos tecnicos)
/// MODEL -> Armazenamento de dados e acesso a dados
/// VIEW -> Telas são as Views
/// CONTROLLER -> É onde programamos as telas
/// 
/// </summary>
namespace Lgroup.SisAmigos.UI.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
