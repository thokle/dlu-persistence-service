using dlu_persistence_api;
using Nancy;
using dlu_persistence_api.services;
using Nancy.ModelBinding;
using Nancy.IO;
using Nancy.Extensions;
using Newtonsoft.Json;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class PriserController : NancyModule
    {
        public PriserController(PriserService service)
        {
          
            Get("priser/GetPrisListePrUge/{bladid:int}", o => service.GetPrisLigePrUge(o.bladid));
            Get("/priser/prislister", o => service.GetPrisLister() );
            Get("/priser/bladpriser/{bladid:int}", o => service.GetPriserFromBladId(o.bladid));
            Get("/priser/{bladid:int}/{placeringd:int}/{aar:int}", o => service.GetPrisListeFromBladidArPlacering(o.bladid, o.placeringd, o.aar));
            Post("/priser/createPriserPrUge/{bladid:int}/{prislisteid:int}", o => { return service.AddPriserPrUge(o.bladid, o.prislisteid); });
            Get("/priser/placering", o => service.GetPlacering());
            Post("/priser/createPrice", o => {
                var body = RequestStream.FromStream(this.Request.Body).AsString();

                var priser = convertToTbLPriser(body);
                return service.CreatePrice(priser);
            });
            Post("/priser/priserPrisListPrBladPrAar7", d =>
            {
                var res = this.Bind<tblPrislisterPrBladPrÅr>();
                return service.CreateOrUpdatePrisListePrBladPrÅr(res);
            });
            
        }

        private tblPriser convertToTbLPriser(string s)
        {
            var priser = JsonConvert.DeserializeObject<tblPriser>(s);
            return priser;
        }
            
    }
}