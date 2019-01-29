using dlu_persistence_api;
using  dlu_persistence_api.services;
using  Nancy;
using  Nancy.ModelBinding;

namespace DLUPersistenceServiceModule.controllers
{
    public class FakturingsBilagController:  NancyModule
    {
        public FakturingsBilagController(FakturingsBilagService service): base("fakturingsbilag")
        {
            Get("medieId/{medieid:int}", o => { return service.GetFakturingsBilagByMedieId(o.medieid); });
            Get("oprettetAf/{oprettetaf:string", o => { return service.GetFakturingsBilagByOprettetAf(o.oprettetaf);});
            Post("opret", o =>
            {
                var tbl = this.Bind<tblFaktureringsBilag>();
                return service.OpretFakturingsBilag(tbl);

            });

        }
    }
}