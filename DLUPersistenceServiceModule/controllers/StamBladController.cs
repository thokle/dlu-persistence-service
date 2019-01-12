using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dlu_persistence_api.daos;
using dlu_persistence_api.mapper;
using dlu_persistence_api.models;
using Nancy;
using dlu_persistence_api;
using Nancy.ModelBinding.DefaultBodyDeserializers;
namespace DLUPersistenceServiceModule.controllers
{
    public class StamBladController: NancyModule
 
    {
        public StamBladController(StamBladsDao stamBladDao):base("/stamblad")

        {
            Get("{id:int}", parametes =>
            {
                int  bladid = parametes.id;
                
                return stamBladDao.GetStamDataById(bladid);
            });

            Post("add", parameter =>
            {
                
               
                return "";
            });
        
        }
    }
}