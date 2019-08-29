using System.Threading;
 using dlu_persistence_api;
 using Nancy;
 using  dlu_persistence_api.services;
 using Nancy.ModelBinding;
using dlu_persistence_api.models;
using Nancy.IO;
using Nancy.Extensions;
using Newtonsoft.Json;

namespace DLUPersistenceServiceModule.controllers
 {
     public sealed class MediePlanNrController: NancyModule
     {
         public MediePlanNrController(MediePlanNrService service)
         {
             Get("/medieplannr/{medieplannr:int}", o => { return service.GetMediePlanNrByMedIePlanNr(o.medieplannr); });
             
             Post("/medieplannr/create", o =>
                 {

                 var body =     RequestStream.FromStream(Request.Body).AsString();


                     var res = service.CreateOrUpDateMediePlanNr(this.convert(body));



                     return res;


                 } 
                 );
             
         }

        private tblMedieplanNr convert(string body)
        {
            try
            {
                var res = JsonConvert.DeserializeObject<MediePlanNr>(body);
                var tbl = new tblMedieplanNr();

                tbl.AktivVersion = res.AktivVersion;
                tbl.AnvendtMilj�Till�g = res.AnvendtMiljoeTillaeg;
                tbl.AnvendtPrisberegningVersion = res.AnvendtPrisberegningVersion;
                tbl.BrugtGruppeVersion = res.BrugtGruppeVersion;
                tbl.FakturaBem�rkning1 = res.FakturaBemaerkning1;
                tbl.FakturaBem�rkning2 = res.FakturaBemaerkning2;
                tbl.FakturaBem�rkning3 = res.FakturaBemaerkning3;
                tbl.Kommentar = res.Kommentar;
                tbl.MaterialeModtaget = res.MaterialeModtaget;
          
                tbl.Overf�rtFraPrisforesp�rgsel = res.Overf�rtFraPrisforespoergsel;
                tbl.Status = res.Status;
                tbl.SupportBilagVedlagt = res.SupportBilagVedlagt;
                tbl.SupportBilagVist = res.SupportBilagVist;
                return tbl;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
     }
 }