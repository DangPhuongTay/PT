namespace WebHotel.WebApp.Extensions
{
    public static class RouteExtensions
    {
        public static IEndpointRouteBuilder UseBlogRoutes(
            this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Blog}/{action=Index}/{id?}"
              );
            endpoints.MapControllerRoute(
               name: "default",
               pattern: "{controller=Blog}/{action=Service}/{id?}"
             );
            endpoints.MapControllerRoute(
               name: "default",
               pattern: "{controller=Blog}/{action=Hotel}/{id?}"
             );
            endpoints.MapControllerRoute(
              name: "default",
              pattern: "{controller=Blog}/{action=Template}/{id?}"
            );
            endpoints.MapControllerRoute(
              name: "default",
              pattern: "{controller=Blog}/{action=Folder}/{id?}"
            );
            endpoints.MapControllerRoute(
              name: "default",
              pattern: "{controller=Blog}/{action=Filer}/{id?}"
            );
            endpoints.MapControllerRoute(
              name: "default",
              pattern: "{controller=Blog}/{action=Employee}/{id?}"
            );
            endpoints.MapControllerRoute(
              name: "default",
              pattern: "{controller=Blog}/{action=Customer}/{id?}"
            );
            endpoints.MapControllerRoute(
              name: "default",
              pattern: "{controller=Blog}/{action=Booking}/{id?}"
            );
            return endpoints;

        }

    }
}