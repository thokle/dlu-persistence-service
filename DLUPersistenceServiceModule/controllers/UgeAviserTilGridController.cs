using dlu_persistence_api.services;
using  Nancy;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class UgeAviserTilGridController: NancyModule
    {
        public UgeAviserTilGridController(UgeAviserTilGridService service) : base("ugeAviserTilGrid")
        {
            Get("/postnr/{postnr:int}", o => service.GetAllUgeAviserGridPostNr(o.postnr));
            Get("/all", o => service.GetAllUgerAviser());
             Get("/bynavn/{bynavn:int}", o => service.GetAllUgeAviserByByNavn(o.bynavm));
        }
    }
}