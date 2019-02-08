using dlu_persistence_api;
using  dlu_persistence_api.services;
using  Nancy;
using  Nancy.ModelBinding;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class FakturingsBilagController:  NancyModule
    {
        public FakturingsBilagController(FakturingsBilagService service): base("fakturingsbilag")
        {
            Get("/fakturingsbilag/medieId/{medieid:int}", o => { return service.GetFakturingsBilagByMedieId(o.medieid); });
            Get("/fakturingsbilag/oprettetAf/{oprettetaf:string", o => { return service.GetFakturingsBilagByOprettetAf(o.oprettetaf);});
            Post("/fakturingsbilag/opret", o =>
            {
                var tbl = this.Bind<tblFaktureringsBilag>();
                return service.OpretFakturingsBilag(tbl);

            });

        }
    }
}