using dlu_persistence_api;
using dlu_persistence_api.services;
using Nancy;
using Nancy.ModelBinding;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class MediePlanLinjerController : NancyModule
    {
        public MediePlanLinjerController(MediePlanLinjerService service) : base("")
        {
            Get("/mediePlanlinjer/{medieid:int}", parameter =>
            {
                var res = service.GetMediePlanLinjerByMedieId(parameter.medieid);

                return res;
            });

            Post("mediePlanlinjer/create", parameter =>
            {
                var p = this.Bind<tblMedieplanLinjer>();
                var res = service.CreateOrUpDate(p);
                return res;
            });
        }
    }
}