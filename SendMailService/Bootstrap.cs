using Nancy;
using Nancy.Bootstrapper;
using Nancy.Conventions;
using Nancy.Swagger;
using Nancy.Swagger.Services;
using Nancy.TinyIoc;

namespace DLUPersistenceServiceModule
{
    public class Bootstrap : DefaultNancyBootstrapper
    {
        protected override void RequestStartup(TinyIoCContainer container, IPipelines pipelines, NancyContext context)
        {
            //CORS Enable
            pipelines.AfterRequest.AddItemToEndOfPipeline(ctx =>
            {
                ctx.Response.WithHeader("Access-Control-Allow-Origin", "*")
                    .WithHeader("Access-Control-Allow-Methods", "POST,GET")
                    .WithHeader("Access-Control-Allow-Headers", "Accept, Origin, Content-type");
            });

            //SwaggerMetadataProvider.SetInfo("Nancy Swagger Example", "v1.0", "Some open api");  
            
            base.ApplicationStartup(container, pipelines); 
        }


        protected override void ConfigureConventions(NancyConventions nancyConventions)
        {
            base.ConfigureConventions(nancyConventions);
            nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("swagger-ui"));
        }
    }
}