using Nancy;
using  dlu_persistence_api.services;
namespace DLUPersistenceServiceModule.controllers
{
    public class MediePlanNrController: NancyModule
    {
        public MediePlanNrController(MediePlanNrService service): base("/medieplannr")
        {
            Get("{medieplannr:int}", o => { return service.GetMediePlanNrByMedIePlanNr(o.medieplannr); });
        }
    }
}