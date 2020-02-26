using dlu_persistence_api.services;
using Nancy;
namespace DLUPersistenceServiceModule.controllers
{
    public sealed class PostNrTableController : NancyModule

    {
        public PostNrTableController(PostNrTableService service)
        {
            Get("/postnr/getall", o => service.GetPostNrListe());
            Get("/postnr/bynavn/{postnr:int}", o => service.GetByBYPostNr(o.postnr));
            Get("/postnr/zipcode/{by:string}", o => service.GetPostNrAfByNavn(o.by));
        }
    }
}