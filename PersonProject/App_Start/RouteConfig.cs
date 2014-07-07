using System.Web.Mvc;
using System.Web.Routing;

namespace PersonProject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // GET http://localhost/People
            routes.MapRoute("All Persons", "People", new { controller = "Person", action = "All" });

            // GET, POST http://localhost/Person
            routes.MapRoute("Create Person", "Person", new {controller = "Person", action = "Create"});

            // GET http://localhost/Person/25
            routes.MapRoute("Show Person", "Person/{id}", new { controller = "Person", action = "Details" });

            // GET http://localhost/Person/25
            routes.MapRoute("Delete Person", "Person/Delete/{id}", new { controller = "Person", action = "DeleteAsync" });

            // GET, POST http://localhost/Person/Edit
            routes.MapRoute("Update Person", "Person/Edit/{id}", new { controller = "Person", action = "Edit" });

            // DEFAULT
            // GET http://localhost/
            routes.MapRoute("Default", "", new { controller = "Person", action = "All" });
        }
    }
}
