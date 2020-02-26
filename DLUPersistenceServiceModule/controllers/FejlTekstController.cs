using dlu_persistence_api;
using dlu_persistence_api.services;
using Nancy;
using Nancy.ModelBinding;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class FejlTekstController : NancyModule
    {
        public FejlTekstController(FejlTekstService service)
        {

            Get("/fejltekst/medieid/{medieId:int}", o => { return service.GetFejlTekstDaoByMedieId(o.medieId); });

            Get("/fejltekst/ansvarlig/{ansvarlig:string}", o =>
            {
                return service.GetFejlodeTekstDaoByAnsvarlig(o.ansvarlig);

            });


            Post("/fejltekst/create", o =>
            {
                var tbl = this.Bind<tblFakturaFejl>();
                return service.CreateOrUpDateFejlTekst(tbl);

            });
        }
    }
}