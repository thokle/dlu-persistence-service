using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using dlu_persistence_api.services;
using dlu_persistence_api;
using Nancy.Extensions;

namespace DLUPersistenceServiceModule.controllers
{
    public class PlaceringController: Nancy.NancyModule
    {
        public PlaceringController(PlaceringService service)
        {
          
            Get("/placeringer", o => service.GetPlaceringer());
            Post("/placeringer",  o => {
                var res = Nancy.IO.RequestStream.FromStream(Request.Body).AsString();
                service.OpretPlacering(convert(res));
                return Response.AsJson("{\"placering\":\"oprettet\"}");
            });
        }

        public tblPlacering convert(string s)
        {
            var res = Newtonsoft.Json.JsonConvert.DeserializeObject<tblPlacering>(s);
            return res;
        }
    }
}