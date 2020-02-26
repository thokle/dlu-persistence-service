using dlu_persistence_api;
using dlu_persistence_api.services;
using Nancy;
using Nancy.ModelBinding;
namespace DLUPersistenceServiceModule.controllers
{
    public sealed class AnnonceKontrolController : NancyModule
    {
        public AnnonceKontrolController(AnnoceKontrolService service)
        {
            Get("/annoncekontrol/email/{email:string}", o => service.GetAnnonceKontrolByEmail(o.email));
            Get("/annoncekontrol/medieId/{medieid:int}", d => service.GetAnnoceKontrolByMediePlanId(d.medieid));
            Post("/annoncekontrol/create", o =>
            {
                var res = this.Bind<tblAnnoncekontrol>();

                return service.CreateOrUpdate(res);

            });

        }
    }
}