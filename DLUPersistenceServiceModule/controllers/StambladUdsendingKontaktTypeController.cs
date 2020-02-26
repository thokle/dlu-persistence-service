using dlu_persistence_api.services;
using Nancy;
namespace DLUPersistenceServiceModule.controllers
{
    public class StambladUdsendingKontaktTypeController : NancyModule
    {
        public StambladUdsendingKontaktTypeController(StambladUdsendingKontaktTypeService service)
        {
            Get("/udsendingKontaktTyper", o => service.GetStamBladUdsendingKontaktType());
        }
    }
}