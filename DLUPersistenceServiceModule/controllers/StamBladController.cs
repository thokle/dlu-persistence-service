using System.Net.Http.Headers;
using dlu_persistence_api;
using dlu_persistence_api.services;
using Nancy;
using Nancy.ModelBinding;

using Nancy.Routing;
using Nancy.Swagger;
using Swagger.ObjectModel;
using Nancy.Swagger.Annotations.Attributes;
using Nancy.Swagger.Services;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class StamBladController : NancyModule

    {
        private const string ServiceTagName = "Service Details";
        private const string ServiceTagDescription = "Operations for handling the service";
        private const string WidgetsTagName = "Available Widgets";
        public StamBladController(StamBladService stamBladDao, ISwaggerModelCatalog modelCatalog, ISwaggerTagCatalog tagCatalog)

        {
            modelCatalog.AddModel<StamBlad>();
            
            tagCatalog.AddTag(new Tag()
            {
                Name = ServiceTagName,
                Description = ServiceTagDescription
                
            });
            
           
            Get("/users", o => { return "user"; }, null,  "GetUsers");
            Get("{id:int}", parametes =>
            {
                int bladid = parametes.id;
                return stamBladDao.GetStamBladById(bladid);
            }, null, "");

          
            Get("/stamblad/postnr/{postnr:int}", parameter => { return stamBladDao.GetStamBladByPostNummer(parameter.postnr); });

            Get("/stamblad/navn/{name:string}", parameter => stamBladDao.GetStamBladByName(parameter.name));


            Post("/stamblad", o =>
            {
                var JSOn = this.Bind<tblBladStamdata>();
                stamBladDao.CreaateOrUpdateStamBlad(JSOn);
                return Response.AsJson(JSOn);
            });

            Get("/stamblad/GeoCodes", o => { return stamBladDao.GetTableGeoCode(); });

            Get("/stamblad/allpostnr", o => { return stamBladDao.GetTablePostNr(); });

            Get("/stamblad/postnrsog", o => { return stamBladDao.GetTablePostNrSøgning(); });

            Get("/stamblad/regions", o => { return stamBladDao.GetTableRegion(); });


            Get("/stamblad/dage", o => { return stamBladDao.GetTableDage(); });
        }

      
    }
}