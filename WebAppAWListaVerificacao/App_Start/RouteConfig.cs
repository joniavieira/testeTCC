﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebAppAWListaVerificacao
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //definicao atributo de roteamento

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Projeto", action = "Index", id = UrlParameter.Optional }
            );

            //

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Teste", action = "Index", id = UrlParameter.Optional }
            //);


            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "InsereTemplate", action = "Index", id = UrlParameter.Optional }
            //);

           // routes.MapRoute(
           //    name: "Default",
           //    url: "{controller}/{action}/{id}",
           //    defaults: new { controller = "Redireciona", action = "Index", id = UrlParameter.Optional }
           //);

        }
    }
}
