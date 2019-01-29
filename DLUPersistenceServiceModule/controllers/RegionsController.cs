using  Nancy.ModelBinding;
using  Nancy;
using dlu_persistence_api.services;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class RegionsController: NancyModule
    {
        public RegionsController(RegionService service) : base("regions")
        {
            
            Get("",  o => service.GetRegions() );
        }
    }
}