using dlu_persistence_api;
using  Nancy;
using Nancy.ModelBinding;
 using dlu_persistence_api.services;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class GruppeController: NancyModule
    {
        public GruppeController(GruppeService service): base("grupåer")
        {
            Get("/id/{id:int}", o => service.GetGruppeByGruppeID(o.id));
            Get("/navn/{navn:string", o => service.GetGruppeByGruppeNavn(o.navn));
            Get("/type/{type:int}", o => service.GetGruppeByGruppeID(o.type));
            Post("", o =>
            {
                var gr = this.Bind<tblGrupper>();
                return service.CreteOrUpdate(gr);

            });
        }
    }
}