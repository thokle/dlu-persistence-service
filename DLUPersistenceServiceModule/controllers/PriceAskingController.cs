using dlu_persistence_api;
using dlu_persistence_api.services;
using Nancy;
using Nancy.ModelBinding;

namespace DLUPersistenceServiceModule.controllers
{
    public class PriceAskingController : NancyModule
    {
        public PriceAskingController(PriceAskingService service)
        {
            Get("/priceasking/{bladid}", o => service.GetPriceAskigListByBladId(o.bladid));
            Post("/priceasking/create", o =>
            {
                var enitry = this.Bind<tblPriceAsking>();
                return service.CreatePriceAskingEntry(enitry);
            });
        }
    }
}