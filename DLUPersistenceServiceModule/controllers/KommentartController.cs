using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using dlu_persistence_api;
using dlu_persistence_api.services;
using Newtonsoft.Json;
using Nancy.IO;
using Nancy.Extensions;

namespace DLUPersistenceServiceModule.controllers
{
    public class KommentartController: NancyModule
    {
        public KommentartController(KommentartService service)
        {
            Get("/kommentart/{bladid:int}", o => service.GetKommentarByStamBladId(o.bladid));
            Post("/kommentart", o =>
            {
                var res = RequestStream.FromStream(Request.Body).AsString();
                return service.CreateBladKommentar(Convert(res));
            });
        }

        private tblBladKommentar Convert(string i)
        {
            var res = JsonConvert.DeserializeObject<tblBladKommentar>(i);
            return res;

              
        }


    }
}