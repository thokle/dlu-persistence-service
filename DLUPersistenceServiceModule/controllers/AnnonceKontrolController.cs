using  Nancy;
using dlu_persistence_api.services;
namespace DLUPersistenceServiceModule.controllers
{
    public class AnnonceKontrolController: NancyModule
    {
        public AnnonceKontrolController(AnnoceKontrolService service)
        {
            Get("email/{email:string}", o => service.GetAnnonceKontrolByEmail(o.email));
            Get("medieId/{medieid:int}", d => service.GetAnnoceKontrolByMediePlanId(d.medieid));
            
            
        }
    }
}