using System;
using System.Web.DynamicData;
using dlu_persistence_api;
using Nancy;
using dlu_persistence_api.daos;
using dlu_persistence_api.services;
using Nancy.ModelBinding;
namespace DLUPersistenceServiceModule.controllers
{
    public sealed class MediePlanController: NancyModule
    {
        private const bool RunAsync = true;

        public MediePlanController(MediePlanService dao)
        {
            Get("/mediePlan/medieId/{medieId:int}", parameters => { return dao.GetMediePlanById(parameters.medieId); });
            Get("/mediePlan/kontaktPerson/{kon taktPerson:string", o => { return dao.GetMediePlanByKontakt(o.kontaktPerson); });
            Get("/mediePlan/tilgrid/{stambladid:int}", p => { return dao.GetAvisTilMediePlan(p.stambladid); });
            Post("/mediePlan/create", o =>
            {
                var mediePlan = this.Bind<tblMedieplan>();

                return dao.CreateOrUpdate(mediePlan);
            } );
        }
    }
}
 