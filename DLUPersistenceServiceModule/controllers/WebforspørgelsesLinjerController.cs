using dlu_persistence_api;
using dlu_persistence_api.services;
using Nancy;
using Nancy.ModelBinding;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class WebforspørgelsesLinjerController : NancyModule
    {
        public WebforspørgelsesLinjerController(WebforspørgelsesLinjerService service)
        {
            Get("/webforspørgelsesLinjer/bladid/{bladid:int}", o => service.GetForspørgelsesLinjerByBladId(o.bladid));
            Post("/webforspørgelsesLinjer/create", o =>
            {

                var res = this.Bind<tblWEBForespørgselLinjer>();

                return service.CreateOrUpdate(res);
            });
        }
    }
}