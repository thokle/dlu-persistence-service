using dlu_persistence_api;
using dlu_persistence_api.services;
using Nancy;
using Nancy.ModelBinding;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class GruppeController : NancyModule
    {
        public GruppeController(GruppeService service)
        {
            Get("/gruppe/id/{id:int}", o => service.GetGruppeByGruppeID(o.id));
            Get("/gruppe/navn/{navn:string", o => service.GetGruppeByGruppeNavn(o.navn));
            Get("/gruppe/type/{type:int}", o => service.GetGruppeByGruppeID(o.type));
            Post("/gruppe/create", o =>
            {
                var gr = this.Bind<tblGrupper>();
                return service.CreteOrUpdate(gr);

            });
        }
    }
}