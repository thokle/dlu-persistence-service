using dlu_persistence_api;
using dlu_persistence_api.services;
using Nancy;
using Nancy.Extensions;
using Nancy.IO;
using Newtonsoft.Json;

namespace DLUPersistenceServiceModule.controllers
{
    public class KommentartController : NancyModule
    {
        public KommentartController(KommentartService service)
        {
            Get("/kommentar/{bladid:int}", o => service.GetKommentarByStamBladId(o.bladid));
            Post("/kommentar", o =>
            {
                var res = RequestStream.FromStream(Request.Body).AsString();
                service.CreateBladKommentar(Convert(res));
                return Response.AsJson("{\"kommentart\": \"oprettet\"}");
            });
        }

        private tblBladKommentar Convert(string i)
        {
            var res = JsonConvert.DeserializeObject<tblBladKommentar>(i);
            return res;


        }


    }
}