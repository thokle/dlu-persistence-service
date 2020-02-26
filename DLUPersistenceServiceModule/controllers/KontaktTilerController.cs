using dlu_persistence_api.services;
using Nancy;
namespace DLUPersistenceServiceModule.controllers
{
    public class KontaktTilerController : NancyModule
    {
        public KontaktTilerController(KontaktTitlerService service)
        {
            Get("/kontaktTitler", o => service.GetTitler());
        }
    }
}