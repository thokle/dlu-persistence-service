
using dlu_persistence_api;
using dlu_persistence_api.services;
using Nancy.ModelBinding;
using  Nancy;
namespace DLUPersistenceServiceModule.controllers
{
    public sealed class MediePlanÆnmdringsController: NancyModule
    {
        public MediePlanÆnmdringsController(MediePlanÆndringsService service)
        {
         Get("/mediePlanAendringer/medieid/{medieid:int}", o => service.GetMediePlanÆndringerByMedieId(o.medieie) );
         Post("/mediePlanAendringer/create", o =>
         {

             var res = this.Bind<tblMedieplanÆndringer>();
          return   Response.AsJson(service.CreateOrUpdate(res));
         });
        }
    }
}