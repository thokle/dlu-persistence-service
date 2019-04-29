using  Nancy;
using  dlu_persistence_api.services;
namespace DLUPersistenceServiceModule.controllers
{
    public class DelOmraadeController: NancyModule
    {
        public DelOmraadeController(DelOmraadeService service)
        {
            Get("/delomraade/all", o => service.GetAllRegions() );
            Get("/delomraade/{id:int}", o => service.GetDelOmraadeById(o.id));
        }
    }
}