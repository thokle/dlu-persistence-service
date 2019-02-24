using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using System.Web.Security;
using dlu_persistence_api;
using Nancy;
using Nancy.Metadata.Modules;
using Nancy.Swagger;
using Nancy.Swagger.Services;
using Swagger.ObjectModel;

namespace DLUPersistenceServiceModule.swagger
{
    public class StambladMetaDataModule: ISwaggerModelDataProvider
    {
        public SwaggerModelData GetModelData()
        {
            return SwaggerModelData.ForType<StamBlad>(with =>
            {
                with.Description("An address of a user");
                with.Property(x => x.BilagsbladeEmail)
                    .Description("First Line of Address")
                    .Required(true);
            });
        }
        
        
        
        
    }

    public class MediePlanDataModule : ISwaggerModelDataProvider
    {


        public SwaggerModelData GetModelData()
        {
            return SwaggerModelData.ForType<tblMedieplan>(with =>
            {
                with.Description("tblMediePlanData");
                with.Property(x => x.MedieplanNr).Description("").Required(true);
                
            });
        }
    }
}