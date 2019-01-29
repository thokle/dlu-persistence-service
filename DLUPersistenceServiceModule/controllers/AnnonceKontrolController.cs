using dlu_persistence_api;
using  Nancy;
using dlu_persistence_api.services;
using  Nancy.ModelBinding;
namespace DLUPersistenceServiceModule.controllers
{
    public sealed class AnnonceKontrolController: NancyModule
    {
        public AnnonceKontrolController(AnnoceKontrolService service)
        {
            Get("email/{email:string}", o => service.GetAnnonceKontrolByEmail(o.email));
            Get("medieId/{medieid:int}", d => service.GetAnnoceKontrolByMediePlanId(d.medieid));
            Post("", o =>
            {
                var res = this.Bind<tblAnnoncekontrol>();

               return service.CreateOrUpdate(res);

            });
            
        }
    }
}