using dlu_persistence_api;
using dlu_persistence_api.services;
using Nancy;
using Nancy.Extensions;
using Nancy.IO;
using Nancy.Swagger;
using Nancy.Swagger.Services;
using Newtonsoft.Json;
using Swagger.ObjectModel;
using System.Linq;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class StamBladController : NancyModule

    {
        private const string ServiceTagName = "Service Details";
        private const string ServiceTagDescription = "Operations for handling the service";
        private const string WidgetsTagName = "Available Widgets";
        public StamBladController(StamBladService stamBladDao, ISwaggerModelCatalog modelCatalog, ISwaggerTagCatalog tagCatalog)

        {
            After.AddItemToEndOfPipeline((ctx) =>
            {
                ctx.Response.WithHeader("Access-Control-Allow-Origin", "*")
                    .WithHeader("Access-Control-Allow-Methods", "POST,GET")
                    .WithHeader("Access-Control-Allow-Headers", "Accept, Origin, Content-type");
            });
            modelCatalog.AddModel<StamBlad>();

            tagCatalog.AddTag(new Tag()
            {
                Name = ServiceTagName,
                Description = ServiceTagDescription

            });


            Get("/users", o => { return "user"; }, null, "GetUsers");
          

         


         

            Get("/stamblad/GeoCodes", o => { return stamBladDao.GetTableGeoCode(); });

        

            Get("/stamblad/postnrsog", o => { return stamBladDao.GetTablePostNrSøgning(); });

            Get("/stamblad/regions", o => { return stamBladDao.GetTableRegion(); });


            Get("/stamblad/dage", o => { return stamBladDao.GetTableDage(); });
            Get("/stamblad/antalblade", o => Response.AsJson(stamBladDao.GetNumbersOfStamblad()));
            Get("/stamblad/bynavn/{postnr:int}", p => stamBladDao.GetByNavnPostNr(p.postnr));
            Get("/stamblad/latestid", o => Response.AsJson(stamBladDao.GetLatestId()));
            Get("/stamblad/ejerforhold/", o =>
            {
                var ejerforhold = Request.Headers["ejerforhold"].SingleOrDefault().ToString();
                return stamBladDao.GetStamBladEfterEjerforhold(ejerforhold);
            });
            Post("/stamblad/ejerforhold/{oldejer:string}/{newejer:string",
                o => stamBladDao.UpdateEjerforholdForAviser(o.oldejer, o.newejer));
        

        }

        private tblBladStamdata CreateStamData(string jsonString)
        {
            var stamDataJson = JsonConvert.DeserializeObject<tblBladStamdata>(jsonString);




            return stamDataJson;
        }



    }
}