using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dlu_persistence_api.services;
using dlu_persistence_api;
using Nancy;
using Nancy.Extensions;
using Newtonsoft.Json;

namespace DLUPersistenceServiceModule.controllers
{
    public class StamBladUdsendigKontakterController: NancyModule
    {
        public StamBladUdsendigKontakterController(StamBladUdsendigKontakterService service)
        {
            Get("/udsendingkontakter/{bladid:int}", o => service.GetUdsendingKontakterPrBladId(o.bladid));
            Post("/udsendingkontakter", async o =>
            {
                var body = Nancy.IO.RequestStream.FromStream(Request.Body).AsString();
                var update = Convert(body);

                var res =  await service.AddOrUpdateKontakterPrBlad(update);
                return Response.AsJson("{\"oprettet\":\"" + res + "\"}");
                });
        }

        private tblBladUdsendingKontakter Convert(String body)
        {
          return  JsonConvert.DeserializeObject<tblBladUdsendingKontakter>(body);
        }
       
    }
}