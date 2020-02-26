using dlu_persistence_api;
using dlu_persistence_api.services;
using Nancy;
using Nancy.Extensions;
using Nancy.IO;

namespace DLUPersistenceServiceModule.controllers
{
    public class StmbladKontaktController : Nancy.NancyModule
    {
        public StmbladKontaktController(StambladKontaktService service)
        {
            Get("/stambladkontakter/{bladid:int}", o => service.GetStamBladKontakterByStambladId(o.bladid));
            Post("/stambladkontakter/add", o =>
            {
                var body = RequestStream.FromStream(Request.Body).AsString();

                var kontakt = CreateStamKontaktData(body);
                return service.AddOrUpdateStamBladKontkt(kontakt);
            });
        }

        private dlu_persistence_api.tblStambladKontakter CreateStamKontaktData(string jsonString)
        {
            var stamDataJson = Newtonsoft.Json.JsonConvert.DeserializeObject<tblStambladKontakter>(jsonString);




            return stamDataJson;
        }
    }
}