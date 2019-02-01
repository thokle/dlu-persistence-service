using dlu_persistence_api;
using Nancy;
using  Nancy.ModelBinding;
using dlu_persistence_api.services;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class SupportBilagController: NancyModule
    {
        public SupportBilagController(SupportBilagService service) : base("supportBilag")
        {
            Get("{medieid:int", o => service.GetSupportBilagByMedieId(o.medieie));
            Post("", o =>
            {
                var supportBilag = this.Bind<tblSupportBilag>();
                return service.CreateOrUpdate(supportBilag);

            });
        }
    }
}