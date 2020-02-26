using dlu_persistence_api;
using dlu_persistence_api.services;
using Nancy;
using Nancy.ModelBinding;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class KonkurrenceDækningsController : NancyModule
    {
        public KonkurrenceDækningsController(KonkurrenceDækningService service)
        {
            Get("/konkurrenceDaekning/byPostnr/{postnr:int}", o => service.GetKomkurrenceDækningPrPostNr(o.postnr));
            Get("/konkurrenceDaekning/ByDaekning/{daekning:int", o => service.GetKonkurrenceDækningPrDaeknngGrad(o.daekning));
            Get("/konkurrenceDaekning/all/", o => service.GetKonkurrenter());
            Post("/konkurrenceDækning/create", o =>
            {
                var res = this.Bind<tblKonkurrentDækning>();
                return service.CreateOrUpdate(res);
            });

        }
    }
}