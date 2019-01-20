﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Nancy;
using dlu_persistence_api.services;
using Nancy;

using dlu_persistence_api;
using dlu_persistence_api.daos;
using Nancy.ModelBinding.DefaultBodyDeserializers;

using Nancy.ModelBinding;

namespace DLUPersistenceServiceModule.controllers
{
    public class StamBladController: NancyModule
 
    {
        public StamBladController(StamBladService stamBladDao) : base("/stamblad")

        {
            Get("{id:int}", parametes =>
            {
                int bladid = parametes.id;
                return stamBladDao.GetStamBladById(bladid);
            });

            Get("postnr/{postnr:int}", parameter => { return stamBladDao.GetStamBladByPostNummer(parameter.postnr); });
            
            Get("navn/{name:string}",  parameter => stamBladDao.GetStamBladByName(parameter.name));


            Post("", o =>
            {  
                var JSOn =  this.Bind<tblBladStamdata>();
                stamBladDao.CreaateOrUpdateStamBlad(JSOn);
                return Response.AsJson(JSOn);
                
            });

            Get("GeoCodes", o => { return stamBladDao.GetTableGeoCode(); });
            
            Get("allpostnr", o => { return stamBladDao.GetTablePostNr(); });

            Get("postnrsog", o => { return stamBladDao.GetTablePostNrSøgning(); });

            Get("regions", o => { return stamBladDao.GetTableRegion(); });
            
            
            Get("dage" , o => { return stamBladDao.GetTableDage(); 
            });


        }
    }
}