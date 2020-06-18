using dlu_persistence_api;
using dlu_persistence_api.models;
using dlu_persistence_api.services;
using Nancy;
using Nancy.Extensions;
using Nancy.IO;

namespace DLUPersistenceServiceModule.controllers
{
    public class BladDækningController : NancyModule
    {
        public BladDækningController(BladDækningService service)
        {
         
            Get("/bladdaekning/postnr/{postnr:int}", o => service.GetBladDækningByPostnr(o.postnr));
            Post("/bladdaekning/add", o =>
           {
               var body = RequestStream.FromStream(Request.Body).AsString();
               var res = createBladDækning(body);
               service.OpretBladDækning(res);
               return "";
           });
            Delete("/bladdaekning/delete/{bladid}/{postnr}", o =>
            {
                var body = RequestStream.FromStream(Request.Body).AsString();

                return service.DeleteDaeking(o.bladid, o.postnr);
            });
        }


        private dlu_persistence_api.tblBladDækning createBladDækning(string jsonString)
        {
            var stamDataJson = Newtonsoft.Json.JsonConvert.DeserializeObject<Bladdaeknik>(jsonString);

            var tblBladDaekning = new tblBladDækning();
            tblBladDaekning.Oplag = stamDataJson.Oplag1;
            tblBladDaekning.PostNr = stamDataJson.PostNr1;
            tblBladDaekning.DækningsGrad = stamDataJson.DaekningsGrad1;
            tblBladDaekning.BladID = stamDataJson.BladID1;


            return tblBladDaekning;
        }
    }
}