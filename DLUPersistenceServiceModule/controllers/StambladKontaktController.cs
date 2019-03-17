using dlu_persistence_api;
using dlu_persistence_api.services;
using Nancy;
using Nancy.ModelBinding;


namespace DLUPersistenceServiceModule.controllers
{
    public sealed class StambladKontaktController : NancyModule
    {
        public StambladKontaktController(StambladKontaktPersonService service)
        {
            Get("/stambladKontaktPersoner/{bladid:int}", o => service.GetKontaktPersonerByBladID(o.bladid));
            Post("/stambladKontaktPersoner", o =>
            {
                var res = this.Bind<StamBladKontaktPersoner>();
                return service.CreateOrUpdateKontaktPerson(res);
            });

        }
    }
    
}