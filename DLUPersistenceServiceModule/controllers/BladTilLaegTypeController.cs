using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy.ModelBinding;
using dlu_persistence_api.services;
using Newtonsoft.Json;
using dlu_persistence_api;
using System.IO;
using Nancy.IO;
using Nancy.Extensions;

namespace DLUPersistenceServiceModule.controllers
{
    public class BladTilLaegTypeController: Nancy.NancyModule
    {
        public BladTilLaegTypeController(BladTilaegsTypeService service)
        {
            Get("/bladtillaegsType/",  o => service.GetBladtillaegsTyper());
            Post("bladtillaegsType/", o => {

              var s = RequestStream.FromStream(Request.Body).AsString();


                return service.CreateOrUpdate(Convert(s));
                ;
            });
        }

        public tblBladTillaegsType Convert(string s)
        {
            var res = JsonConvert.DeserializeObject<tblBladTillaegsType>(s);

            return res;
        }

    }
}