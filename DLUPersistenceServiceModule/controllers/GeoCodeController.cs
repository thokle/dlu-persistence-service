using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using dlu_persistence_api.services;
namespace DLUPersistenceServiceModule.controllers
{
    public class GeoCodeController: NancyModule
    {
        public GeoCodeController(GeoCodeService service)
        {
            Get("/geocode/{id:int}", o => service.GetGeoCodeById(o.id));
        }
    }
   
}