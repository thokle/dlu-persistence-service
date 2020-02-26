using dlu_persistence_api.services;
using Nancy;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class RegionsController : NancyModule
    {
        public RegionsController(RegionService service)
        {

            Get("/regions/all", o => service.GetRegions());

            Get("/regions/singleregion/{regionid:int}", o => service.GetRegsionById(o.regionid));
        }

    }
}