﻿﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using dlu_persistence_api.mapper;
using dlu_persistence_api.models;
using dlu_persistence_api.services;
using Nancy;

using dlu_persistence_api;
using Nancy.ModelBinding.DefaultBodyDeserializers;

using Nancy.ModelBinding;

namespace DLUPersistenceServiceModule.controllers
{
    public class StamBladController: NancyModule
 
    {
        public StamBladController(IStamBladService stamBladDao) : base("/stamblad")

        {
            Get("{id:int}", parametes =>
            {
                int bladid = parametes.id;
                return stamBladDao.GetStamBladById(bladid);
            });

            Get("/postnr{postnr:int}", parameter => { return stamBladDao.GetStamBladByPostNummer(parameter.postnr); });
            
            Get("name/{name:string}",  parameter =>
            {
                return stamBladDao.GetStamBladByName(parameter.name);
            });
            
           Post("add", o =>
           {
               var stamblad = this.Bind<tblBladStamdata>(o);
               return stamBladDao.CreaateOrUpdateStamBlad(stamblad);

           }, context => { context.Parameters. });
            
           


    }
    }
}