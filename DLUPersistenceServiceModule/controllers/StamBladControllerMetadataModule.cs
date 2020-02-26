using Nancy.Metadata.Modules;
using Nancy.Swagger;
using Swagger.ObjectModel;

namespace DLUPersistenceServiceModule.controllers
{
    public class StamBladControllerMetadataModule : MetadataModule<PathItem>

    {
        public StamBladControllerMetadataModule()
        {

            Describe["GetUsers"] = description => description.AsSwagger(
                with => with.Operation(
                    op => op.OperationId("GetUsers")
                        .Tag("Users")
                        .Summary("The list of users")
                        .Description("This returns a list of users from our awesome app")
                        .Response(r => r.Schema<StamBlad>().Description("The list of users"))));


        }
    }
}