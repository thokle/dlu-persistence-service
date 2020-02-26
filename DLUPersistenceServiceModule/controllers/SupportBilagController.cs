using dlu_persistence_api;
using dlu_persistence_api.services;
using Nancy;
using Nancy.ModelBinding;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class SupportBilagController : NancyModule
    {
        public SupportBilagController(SupportBilagService service)
        {
            Get("/supportBilag/{medieid:int", o => service.GetSupportBilagByMedieId(o.medieie));
            Post("/supportBilag/create", o =>
            {
                var supportBilag = this.Bind<tblSupportBilag>();
                return service.CreateOrUpdate(supportBilag);

            });
        }
    }
}