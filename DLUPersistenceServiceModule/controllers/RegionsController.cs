using  Nancy.ModelBinding;
using  Nancy;
using dlu_persistence_api.services;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class RegionsController: NancyModule
    {
        public RegionsController(RegionService service)
        {
            
            Get("/regions/all",  o => service.GetRegions() );
        }
    }
}