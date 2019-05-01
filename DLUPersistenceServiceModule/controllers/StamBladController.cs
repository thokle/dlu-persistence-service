using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using dlu_persistence_api;
using dlu_persistence_api.services;
using Nancy;
using Nancy.ModelBinding;

using Nancy.Routing;
using Nancy.Swagger;
using Swagger.ObjectModel;
using Nancy.Swagger.Annotations.Attributes;
using Nancy.Swagger.Services;
using Nancy.IO;
using Nancy.Extensions;
using Nancy.Helpers;
using Newtonsoft.Json;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class StamBladController : NancyModule

    {
        private const string ServiceTagName = "Service Details";
        private const string ServiceTagDescription = "Operations for handling the service";
        private const string WidgetsTagName = "Available Widgets";
        public  StamBladController(StamBladService stamBladDao, ISwaggerModelCatalog modelCatalog, ISwaggerTagCatalog tagCatalog)

        {
            modelCatalog.AddModel<StamBlad>();
            
            tagCatalog.AddTag(new Tag()
            {
                Name = ServiceTagName,
                Description = ServiceTagDescription
                
            });
            
           
            Get("/users", o => { return "user"; }, null,  "GetUsers");
            Get("/stamblad/{id:int}", parametes =>
            {
                int bladid = parametes.id;
                return stamBladDao.GetStamBladById(bladid);
            }, null, "");

          
            Get("/stamblad/postnr/{postnr:int}", parameter => { return stamBladDao.GetStamBladByPostNummer(parameter.postnr); });

            Get("/stamblad/navn/{name:string}", parameter => stamBladDao.GetStamBladByName(parameter.name));


            Post("/stamblad", o =>
            {
                var body = RequestStream.FromStream(Request.Body).AsString();

              var stamData =  this.CreateStamData(body);

                stamBladDao.CreaateOrUpdateStamBlad(stamData);
                return Response.AsJson(body);
            });

            Get("/stamblad/GeoCodes", o => { return stamBladDao.GetTableGeoCode(); });

            Get("/stamblad/allpostnr", o => { return stamBladDao.GetTablePostNr(); });

            Get("/stamblad/postnrsog", o => { return stamBladDao.GetTablePostNrSøgning(); });

            Get("/stamblad/regions", o => { return stamBladDao.GetTableRegion(); });


            Get("/stamblad/dage", o => { return stamBladDao.GetTableDage(); });
            Get("/stamblad/antalblade", o => Response.AsJson(stamBladDao.GetNumbersOfStamblad()));
            Get("/stamblad/bynavn/{postnr:int}" , p => stamBladDao.GetByNavnPostNr(p.postnr));
            Get("/stamblad/latestid" ,o => Response.AsJson(stamBladDao.GetLatestId()));
            Get("/stamblad/ejerforhold/", o =>
            {
                var ejerforhold = Request.Headers["ejerforhold"].SingleOrDefault().ToString();
                return stamBladDao.GetStamBladEfterEjerforhold(ejerforhold);
            });
            Post("/stamblad/ejerforhold/{oldejer:string}/{newejer:string",
                o => stamBladDao.UpdateEjerforholdForAviser(o.oldejer, o.newejer));
            Get("/stamblad/getAllBladid", o => stamBladDao.GetAllIds());

        }

        private tblBladStamdata CreateStamData(string jsonString)
        {
           var stamDataJson =    JsonConvert.DeserializeObject<tblBladStamdata>(jsonString);
          
     


            return stamDataJson;
        }
       

      
    }
}