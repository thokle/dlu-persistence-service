using Nancy.Swagger;
using Nancy.Swagger.Modules;
using Nancy.Swagger.Services;
using Nancy.Swagger.Services.RouteUtils;
using Swagger.ObjectModel;

namespace DLUPersistenceServiceModule.swagger
{
    public class StambladMetaPathItemMetaDataModule : SwaggerMetadataModule
    {
        public StambladMetaPathItemMetaDataModule(ISwaggerModelCatalog modelCatalog, ISwaggerTagCatalog tagCatalog) : base(modelCatalog, tagCatalog)
        {
            RouteDescriber.AddBaseTag(new Tag()
            {
                Description = "Operations for handling the service",
                Name = "Service"
            });

            RouteDescriber.AddAdditionalModels(typeof(StamBlad), typeof(StamBlad));
            RouteDescriber.DescribeRoute<StamBlad>("/stamblad/navn/{name:string}", "", "Get Details", new[]
            {
                new HttpResponseMetadata {Code = 200, Message = "OK"}
            });


        }
    }
}