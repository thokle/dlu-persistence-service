using dlu_persistence_api;
using dlu_persistence_api.services;
using  Nancy.ModelBinding;
using Nancy;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class KonkurrenceDækningsController: NancyModule
    {
        public KonkurrenceDækningsController(KonkurrenceDækningService service) : base("konkurrnceDækning")
        {
            Get("byPostnr/{postnr:int}", o =>  service.GetKomkurrenceDækningPrPostNr(o.postnr));
            Get("ByDaekning/{daekning:int", o => service.GetKonkurrenceDækningPrDaeknngGrad(o.daekning));
            Post("", o =>
            {
                var res = this.Bind<tblKonkurrentDækning>();
              return  service.CreateOrUpdate(res);
            });
            
        }
    }
}