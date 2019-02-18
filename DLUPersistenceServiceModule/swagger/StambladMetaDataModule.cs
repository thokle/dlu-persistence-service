using System.Collections;
using dlu_persistence_api;
using Nancy.Metadata.Modules;
using Nancy.Swagger;
using Swagger.ObjectModel;

namespace DLUPersistenceServiceModule.swagger
{
    public class StambladMetaDataModule: MetadataModule<PathItem>
    {
        public StambladMetaDataModule(ISwaggerModelCatalog catalog)
        {
            catalog.AddModels(typeof(tblBladStamdata));
            Describe["/stamblad/postnr/{postnr:int}/"] = describe =>
                describe.AsSwagger(with => with.Operation(op => op.OperationId(("/stamblad/postnr")).Tag(("Users"))
                    .Response(r => r.Schema<tblBladStamdata>(catalog).Description("StamBlad data"))));
        }
    }
}