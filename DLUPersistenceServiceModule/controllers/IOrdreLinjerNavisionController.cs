using dlu_persistence_api;
using dlu_persistence_api.services;
using  Nancy.ModelBinding;
using  Nancy;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class IOrdreLinjerNavisionController: NancyModule
    {
        public IOrdreLinjerNavisionController(OrdreLinjerNavisionService service)
        {
            Get("/ordernavisionlinjer/bladid/{bladid:int}", o => service.GetOrderLinerByBladID(o.bladid) );
            Get("/ordernavisionlinjer/bureaordernr/{bureaordernr:int}", o => service.GetOrderLinjerByBureaOrderNr(o.bureaordernr)  );
            Post("/ordernavisionlinjer/create", o =>
            {

                var order = this.Bind<tblOrdreLinjerNavision>();

                return service.CreateOrUpdate(order);
            } );
        }
    }
}