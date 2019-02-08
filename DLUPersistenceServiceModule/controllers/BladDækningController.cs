using dlu_persistence_api;
using dlu_persistence_api.services;
using Nancy;
using Nancy.ModelBinding;

namespace DLUPersistenceServiceModule.controllers
{
    public class BladDækningController : NancyModule
    {
        public BladDækningController(BladDækningService service)
        {
            Get("/bladdækning/bladid/{bladid:int", o => service.GetBladDækningByBladId(o.bladid));
            Get("/bladdækning/postnr/{postnr:int", o => service.GetBladDækningByPostnr(o.postnr));
            Post("/bladdækning/add", async o =>
            {
                var tbl = this.Bind<tblBladDækning>();
                var res = await service.OpretBladDækning(tbl);
            });
        }
    }
}