using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using dlu_persistence_api.services;
namespace DLUPersistenceServiceModule.controllers
{
    public class MediePlanAviserController:  NancyModule
    {
        public MediePlanAviserController(MediePlanAviserService service) 
        {
            Get("/medieplanavis/{bladid}/{year}", o => service.GetAllUgeAvisTilGrid(o.bladid, o.year));                
        }
    }
}