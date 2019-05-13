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
        public BladTilLaegTypeController(BladTillaegsTypeService service)
        {
            Get("/bladtillaegsType/{int:bladid}",  o => service.GetBladTilKLaegs(o.bladid));
            Post("bladtillaegsType", o => {

              var s = RequestStream.FromStream(Request.Body).AsString();


                return service.CreateBladTillaegs(Convert(s));
                ;
            });
        }

        public tblBladTiLaegsType Convert(string s)
        {
            var res = JsonConvert.DeserializeObject<tblBladTiLaegsType>(s);

            return res;
        }

    }
}