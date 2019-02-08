using dlu_persistence_api;
using Nancy;
using dlu_persistence_api.services;
using Nancy.ModelBinding;
namespace DLUPersistenceServiceModule.controllers
{
    public sealed class PriserController : NancyModule
    {
        public PriserController(PriserService service)
        {
            Get("/priser/GetPrislisterPraarByBladId/{bladid:int}",o => service.GetPrislisterPrÅrByBladId(o.bladid) );
            Get("priser/GetPrisListePrUge/{bladid:int}", o => service.GetPrisLigePrUge(o.bladid));
            Get("/priser/prislister", o => service.GetPrisLister() );
            Post("/priser/createPriserPrUge/{bladid:int}", o => { return service.AddPriserPrUge(o.bladid); });
            Post("/priser/priserPrisListPrBladPrAar7", d =>
            {
                var res = this.Bind<tblPrislisterPrBladPrÅr>();
                return service.CreateOrUpdatePrisListePrBladPrÅr(res);
            });
            
        }
    }
}