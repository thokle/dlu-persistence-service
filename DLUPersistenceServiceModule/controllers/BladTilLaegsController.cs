using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using dlu_persistence_api.services;
using dlu_persistence_api;
using Newtonsoft.Json;
using Nancy.IO;
using Nancy.Extensions;

namespace DLUPersistenceServiceModule.controllers
{
    public class BladTilLaegsController: NancyModule
    {
       public BladTilLaegsController(BladTilaegsServcie bladTilaegsServcie)
        {
            Get("/bladtillaegbybladid/{bladid}", o => bladTilaegsServcie.GetTillaegsTypeByBladId(o.bladid) );
            
            Post("/bladtilaeg/", o => {

              var res =   RequestStream.FromStream(Request.Body).AsString();
                 bladTilaegsServcie.CreateOrUpdate(Convert(res));
                return Response.AsJson("{\"\"Tillæg\":\"\"Oprettet\"}");
            });          
        }

        private tblBladTillaeg Convert(string s)
        {
            var res = JsonConvert.DeserializeObject<tblBladTillaeg>(s);
            return res;
        }

    }
}