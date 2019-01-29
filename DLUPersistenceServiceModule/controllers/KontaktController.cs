using dlu_persistence_api.services;
using Nancy.ModelBinding;
using Nancy;
namespace DLUPersistenceServiceModule.controllers
{
    public sealed class KontaktController:  NancyModule
    {
        public KontaktController(KontaktService service) : base("/kontakter")
        {
            Get("/OmraadeKontakter", o => service.GetKontakterArbOmråderKontkter());
            Get("/kontaktTitler", o => service.GetKontaktTitler());
            Get("/kontakterPrBlad/{medieId:int}", o => service.GetKontakterPrBlad(o.medieId));
        }
    }
}