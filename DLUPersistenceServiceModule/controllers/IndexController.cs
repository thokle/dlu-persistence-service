using Nancy;


namespace DLUPersistenceServiceModule.controllers
{
    public sealed class IndexController : Nancy.NancyModule
    {
        public IndexController()
        {


            Get("/swagger/", _ =>
            {

                return Response.AsRedirect($"http://petstore.swagger.io/?url=http://localhost:49485/api-docs");
            });
            Get("/swagger-ui/", _ => { return Response.AsRedirect("http://localhost:49485/swagger-ui/"); });
        }
    }
}