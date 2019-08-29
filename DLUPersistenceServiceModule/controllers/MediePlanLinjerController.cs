using dlu_persistence_api;
using dlu_persistence_api.models;
using dlu_persistence_api.services;
using Nancy;
using Nancy.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class MediePlanLinjerController : NancyModule
    {
     

        public MediePlanLinjerController(MediePlanLinjerService service)
        {
            Get("/mediePlanlinjer/{medieid:int}", parameter =>
            {
                var res = service.GetMediePlanLinjerByMedieId(parameter.medieid);

                return res;
            });

            Post("/mediePlanlinjer/create/{num}/{num2}", parameter =>
            {
              var body=   Nancy.IO.RequestStream.FromStream(Request.Body).AsString();

          
              
             var res =     service.CreateOrUpdateMediePlanLinjer(convert(body));
           


                
                return res;
            });
        }

        private List<tblMedieplanLinjer> convert(string body)
        {
            try
            {
                var m = JsonConvert.DeserializeObject<List<MediePlanLinjer>>(body);

                var tbllist = new List<tblMedieplanLinjer>();
                foreach (var res in m)
                {
                    var tbl = new tblMedieplanLinjer();

                    tbl.Bemærkning = res.Bemaerkning;
                    tbl.BureauOrdreNr = res.BureauOrdreNr;
                    tbl.ErWeekendGruppe = res.ErWeekendGruppe;
                    tbl.FarveMax = res.FarveMax;
                    tbl.FarveMin = res.FarveMin;
                    tbl.FarvePris = res.FarvePris;
                    tbl.FarveRabat = res.FarveRabat;
                    tbl.FarveTillæg = res.FarveTillaeg;
                    tbl.FarveTotal = res.FarveTotal;
                    tbl.ManueltÆndret = res.ManueltAendret;
                    tbl.MaterialeGodtgørelsePris = res.MaterialeGodtgoerelsePris;
                    tbl.MaterialeNr = res.MaterialeNr;
                    tbl.MedieplanNr = res.MedieplanNr;
                    tbl.MedIGrupper = res.MedIGrupper;
                    tbl.MiljøTillæg = res.MiljoeTillaeg;
                    tbl.Mm = res.Mm;
                    tbl.MmPris = res.MmPris;
                    tbl.MmRabat = res.MmRabat;
                    tbl.MmTotal = res.MmTotal;
                    tbl.MåGiveMaterialeGodtgørelse = res.MaaGiveMaterialeGodtgoerelse;
                    tbl.MåGiveMmRabat = res.MaaGiveMmRabat;
                    tbl.NormalMmPris = res.NormalMmPris;
                    tbl.PrisLåst = res.PrisLaast;
                    tbl.SkalGiveMaterialeGodtgørelse = res.SkalGiveMaterialeGodtgoerelse;
                    tbl.RabatGruppe = res.RabatGruppe;
                    tbl.SendeGruppe = res.SendeGruppe;
                    tbl.Total = res.Total;
                    tbl.TotalInclTillæg = res.TotalInclTillaeg;
                    tbl.TotalPris = res.TotalPris;
                    tbl.UgeavisID = res.UgeavisID;
                    tbl.Version = res.Version;
                    tbl.WebtillægFaktureresHer = res.WebtillaegFaktureresHer;
                    
              

                    tbllist.Add(tbl);
                }
               

                return tbllist;
            }
            catch (System.Exception e)
            {

                throw new Exception(e.Message);
            }
           
                
                }
    }
}