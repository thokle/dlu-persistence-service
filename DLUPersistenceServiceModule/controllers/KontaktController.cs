using dlu_persistence_api.services;
using Nancy.ModelBinding;
using Nancy;
namespace DLUPersistenceServiceModule.controllers
{
    public sealed class KontaktController:  NancyModule
    {
        public KontaktController(KontaktService service) 
        {
            Get("/kontakter/OmraadeKontakter", o => service.GetKontakterArbOmråderKontkter());
            Get("/kontakter/kontaktTitler", o => service.GetKontaktTitler());
            Get("/kontakter/kontakterPrBlad/{medieId:int}", o => service.GetKontakterPrBlad(o.medieId));
        }
    }
}