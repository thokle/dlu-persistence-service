using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dlu_persistence_api.daos;
using dlu_persistence_api.mapper;
using dlu_persistence_api.models;
namespace DLUPersistenceServiceModule.controllers
{
    public class StamBladController: Nancy.NancyModule
 
    {
        public StamBladController(StamBladsDao stamBladDao):base("/stamblad")

        {
            
            Post("/add" = (parameter, _) =>
           {
               var stamblad = this.Request.Body;

               stamBladDao.OpretNytStamBlad(stamblad);
           });
            Get("get/:id" = b =>
            {


            });
        }
    }
}