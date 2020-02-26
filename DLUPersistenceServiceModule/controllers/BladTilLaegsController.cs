using dlu_persistence_api;
using dlu_persistence_api.services;
using Nancy;
using Nancy.Extensions;
using Nancy.IO;
using Newtonsoft.Json;

namespace DLUPersistenceServiceModule.controllers
{
    public class BladTilLaegsController : NancyModule
    {
        public BladTilLaegsController(BladTilaegsServcie bladTilaegsServcie)
        {
            Get("/bladtillaegbybladid/{bladid}", o => bladTilaegsServcie.GetTillaegsTypeByBladId(o.bladid));

            Post("/bladtilaeg/", o =>
            {

                var res = RequestStream.FromStream(Request.Body).AsString();
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