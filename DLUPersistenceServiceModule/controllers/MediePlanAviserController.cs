using dlu_persistence_api.services;
using Nancy;
namespace DLUPersistenceServiceModule.controllers
{
    public class MediePlanAviserController : NancyModule
    {
        public MediePlanAviserController(MediePlanAviserService service)
        {
            Get("/medieplanavis/{bladid}/{year}/{placerigid}", o => service.GetAllUgeAvisTilGrid(o.bladid, o.year, o.placerigid));
        }
    }
}