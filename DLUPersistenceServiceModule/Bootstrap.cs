using System.Collections.Generic;
using System.IO;
using System.Web.UI.WebControls;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.Configuration;
using Nancy.Conventions;
using Nancy.Swagger.Annotations;
using Nancy.Swagger.Services;
using Nancy.TinyIoc;
using Swagger.ObjectModel;

namespace DLUPersistenceServiceModule
{
    public class Bootstrap : DefaultNancyBootstrapper
    {

        public override void Configure(INancyEnvironment environment)
        {
            base.Configure(environment);
            environment.Tracing(enabled: true, displayErrorTraces: true);
        }
        protected override void RequestStartup(TinyIoCContainer container, IPipelines pipelines, NancyContext context)
        {
            //CORS Enable
            pipelines.AfterRequest.AddItemToEndOfPipeline(ctx =>
            {
                ctx.Response.WithHeader("Access-Control-Allow-Origin", "*")
                    .WithHeader("Access-Control-Allow-Methods", "POST,GET")
                    .WithHeader("Access-Control-Allow-Headers", "Accept, Origin, Content-type, username, password, Access-Control-Allow-Origin, ejerforhold");
            });
            
          
            SwaggerMetadataProvider.SetInfo("Nancy Swagger Example", "v0", "Our awesome service", new Contact()
            {
                EmailAddress = "exampleEmail@example.com"
            });
            
            base.ApplicationStartup(container, pipelines);

        }

    

        protected override void ConfigureConventions(NancyConventions nancyConventions)
        {
            base.ConfigureConventions(nancyConventions);

            nancyConventions.StaticContentsConventions.Add(
                StaticContentConventionBuilder.AddDirectory("/swagger-ui/dist")
            );
        }
        
        
       
    }
}