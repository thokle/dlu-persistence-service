using System;
using System.Web.DynamicData;
using dlu_persistence_api;
using Nancy;
using dlu_persistence_api.daos;
using dlu_persistence_api.services;
using Nancy.ModelBinding;
using Nancy.Extensions;
using Newtonsoft.Json;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class MediePlanController: NancyModule
    {
        private const bool RunAsync = true;

        public MediePlanController(MediePlanService dao)
        {

            Get("/mediePlan/medieId/{medieId:int}", parameters => { return dao.GetMediePlanByNumber(parameters.medieId); });
            Get("/mediePlan/kontaktPerson/{kon taktPerson:string", o => { return dao.GetMediePlanByKontakt(o.kontaktPerson); });
            Get("/mediePlan/tilgrid/{stambladid:int}", p => { return dao.GetAvisTilMediePlan(p.stambladid); });
            Get("/mediePlan/annoncoer/{annoncoer}", p => dao.GetMediePlanByAnnoncoer(p.annoncoer));
            Get("/mediePlan/toolbar/{mediePlan}/{annoncoer}/{bureau}/{fraUge}/{tilUge}/{aar}/{visInAktiveAnnoncer}/{mediePlanCheckBox}/{rtAkCheckBox}/{fakuering}", p => { return dao.findMediePlanToolbar(p.mediePlan, p.annoncoer, p.bureau, p.fraUge, p.tilUge, p.aar, p.visInAktiveAnnoncer, p.mediePlanCheckBox, p.rtAkCheckBox, p.faktuering); });
            Post("/mediePlan/create", o =>
            {
                var stream = Nancy.IO.RequestStream.FromStream(Request.Body).AsString();
            

                return dao.CreateOrUpdate(convertFromJson(stream));
            } );
          Get("/mediePlan/getlatestId" , o =>  Response.AsJson(dao.GetLatestMedienr()) );
        }


        private tblMedieplan convertFromJson(string json)
        {
            var res = JsonConvert.DeserializeObject<tblMedieplan>(json);
            return res;
        }

    }
}
 