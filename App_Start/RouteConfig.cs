using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MovieRental
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //varianta noua
            routes.MapMvcAttributeRoutes();

            //Acest cod e mai vechi si trebuie sa imi amintesc sa schimb fiecare chichita, dar pot face si cu Atribute Routing
            //custom route added here conteaza ordinea in care le punem - de la most specific la most generic
            //routes.MapRoute(
                //"MoviesByReleaseDate",
                //"movies/released/{year}/{month}",
                //new { controller = "Movies", action = "ByReleaseDate" },
                //acest argument foloseste un animus object si aplic regular expresion ca sa aplic niste constrangeri
                // d vine de la digit si numarul inseamna numarul de repetii. Aron trebuie pus pt ca \ inseamna altceva singur.
               // new { year = @"\d{4}", month = @"\d{2}" });
                //costom routes.. adica aici pot sa am restrictie intre 2015 si 2016 sa fie anul
                // new { year = @"\d{4}", month = @"\d{2}" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
