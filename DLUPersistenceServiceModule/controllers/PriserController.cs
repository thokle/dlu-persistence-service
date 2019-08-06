using System.Runtime.Remoting.Messaging;
using dlu_persistence_api;
using Nancy;
using dlu_persistence_api.services;
using Nancy.ModelBinding;
using Nancy.IO;
using Nancy.Extensions;
using Newtonsoft.Json;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class PriserController : NancyModule
    {
        public PriserController(PriserService service)
        {
           
            Get("/priser/GetPrisListePrUge/{bladid}/year/{year}", o => service.GetPrisLigePrUge(o.bladid, o.year));
            Get("/priser/{bladid}/add/{year}", o => service.GetPrisLigePrUge(o.bladid, o.year));
            Get("/priser/prislister", o => service.GetPrisLister() );
            Get("/priser/bladpriser/{bladid:int}", o => service.GetPriserFromBladId(o.bladid));
            Get("/priser/{bladid}/{placeringid}/{aar}/{prislisteid}", o =>  service.GetPrisListeFromBladidArPlacering(o.bladid, o.placeringid, o.aar, o.prislisteid));
            Get("/priser/table/{bladid}/{prislisteid}/{aar}", o =>
            {
                return service.GetPrislisteFortable(o.bladid, o.aar, o.prislisteid);
            });
            Get("/priser/createPriserPrUge/{bladid}/{prislisteid}/{year}",  async o => {



              var res = await  service.AddPriserPrUge(o.bladid, o.prislisteid, o.year);
                return "";

            });
            Get("/priser/updateWeek/{bladid}/{listid}/{week}/{year}", o =>
            {
                var tblPrislisterPrBladPrUge = new tblPrislisterPrBladPrUge();
                tblPrislisterPrBladPrUge.BladID = o.bladid;
                tblPrislisterPrBladPrUge.PrislisteID = o.listid;
                tblPrislisterPrBladPrUge.Uge = o.week;
                tblPrislisterPrBladPrUge.År = o.year;
           
               service.UpdateWeekListId(tblPrislisterPrBladPrUge);
                return JsonConvert.SerializeObject(tblPrislisterPrBladPrUge, Formatting.Indented);
            });
            Get("/priser/placering", o => service.GetPlacering());
            Post("/priser/createPrice", o => {
                var body = RequestStream.FromStream(this.Request.Body).AsString();

                var priser = convertToTbLPriser(body);
                 service.CreatePrice(priser);
                return Response.AsJson("{\"pris er\": \"oprettet \"}");
            });
            Post("/priser/priserPrisListPrBladPrAar/", d =>
            {
                var res = this.Bind<tblPrislisterPrBladPrÅr>();
                return service.CreateOrUpdatePrisListePrBladPrÅr(res);
            });

            Delete("/priser/{bladid}/{priserliste}/{placering}/{year}", o => {

                service.DeletePris(o.bladid, o.priserliste, o.placering, o.year);
                return Response.AsJson("{\"pris er\": \"slettet \"}");
            }  );
        }

        private tblPriser convertToTbLPriser(string s)
        {
            var priser = JsonConvert.DeserializeObject<Priser>(s);

           var tp = new tblPriser();

            tp.BladID = priser.BladID1;
            tp.ControlNavn = priser.ControlNavn1;

            tp.Farve4Max = priser.Farve4Max1;
            tp.Farve4Min = priser.Farve4Min1;
            tp.Farve4Pris = priser.FarvePris1;
            tp.FarveMax = priser.FarveMax1;
            tp.FarveMin = priser.FarveMin1;
            tp.FarvePris = priser.FarvePris1;
            tp.FormatFra = priser.FormatFra1;
            tp.FormatTil = priser.FormatTil1;
            tp.mmPris = priser.mmPris;
            tp.PlaceringID = priser.PlaceringID1;
            tp.PrislisteID = priser.PrislisteID1;
            tp.År = priser.AAr1;
            return tp;
        }
            
    }

    public  class Priser
    {

        public int PrislisteID1 { get; set; }
        public byte PlaceringID1 { get; set; }
        public int FormatFra1 { get; set; }
        public int FormatTil1 { get; set; }
        public int BladID1 { get; set; }
        public short AAr1 { get; set; }
        public int mmPris { get; set; }
        public int FarvePris1 { get; set; }
        public int Farve4Pris1 { get; set; }
        public int Farve4Max1 { get; set; }
        public int Farve4Min1 { get; set; }
        public int FarveMax1 { get; set; }
        public int FarveMin1 { get; set; }
        public string ControlNavn1 { get; set; }
    }

   
 }