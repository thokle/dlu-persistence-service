using dlu_persistence_api.services;
using Nancy;
namespace DLUPersistenceServiceModule.controllers
{
    public class GeoCodeController : NancyModule
    {
        public GeoCodeController(GeoCodeService service)
        {
            Get("/geocode/{id:int}", o => service.GetGeoCodeById(o.id));
        }
    }

}