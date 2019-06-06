using System.Web.Http;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Web.Http.Cors;

namespace WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            config.EnableCors();
            config.MapHttpAttributeRoutes();
            //Enable Cors
            //config.EnableCors(new EnableCorsAttribute("http://localhost:4200/", headers: "*", methods: "*"));

            
            //config.EnableCors(new EnableCorsAttribute("http://localhost:4200/",headers:"*",methods:"*"));

            // Web API configuration and services

            // Web API routes
            //config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
