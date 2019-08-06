using dlu_persistence_api.services;
using  Nancy;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class UgeAviserTilGridController: NancyModule
    {
        public UgeAviserTilGridController(UgeAviserTilGridService service) 
        {
            Get("/ugeAviserTilGrid/postnr/{postnr:int}", o => service.GetAllUgeAviserGridPostNr(o.postnr));
            Get("/ugeaviserTtilgrid/all", o => service.GetAllUgerAviser());
             Get("/ugeAviserTilGrid/bynavn/{bynavn:int}", o => service.GetAllUgeAviserByByNavn(o.bynavm));
        }
    }
}