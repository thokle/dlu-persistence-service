using dlu_persistence_api;
using dlu_persistence_api.services;
using Nancy.ModelBinding;
using Nancy;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class FejlTekstController: NancyModule
    {
        public FejlTekstController(FejlTekstService service): base("/fejltekst")
        {

            Get("/medieid/{medieId:int}", o => { return service.GetFejlTekstDaoByMedieId(o.medieId); });
            
           Get("/ansvarlig/{ansvarlig:string}", o =>
           {
               return service.GetFejlodeTekstDaoByAnsvarlig(o.ansvarlig);
               
           } );


            Post("", o =>
            {
                var tbl = this.Bind<tblFakturaFejl>();
                return service.CreateOrUpDateFejlTekst(tbl);

            });
        }
    }
}