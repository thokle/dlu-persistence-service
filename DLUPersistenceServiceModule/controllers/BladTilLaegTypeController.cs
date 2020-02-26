using dlu_persistence_api;
using dlu_persistence_api.services;
using Nancy.Extensions;
using Nancy.IO;
using Newtonsoft.Json;

namespace DLUPersistenceServiceModule.controllers
{
    public class BladTilLaegTypeController : Nancy.NancyModule
    {
        public BladTilLaegTypeController(BladTilaegsTypeService service)
        {
            Get("/bladtillaegsType/", o => service.GetBladtillaegsTyper());
            Post("bladtillaegsType/", o =>
            {

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