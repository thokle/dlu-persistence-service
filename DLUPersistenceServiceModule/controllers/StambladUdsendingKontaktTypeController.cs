using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using dlu_persistence_api.services;
namespace DLUPersistenceServiceModule.controllers
{
    public class StambladUdsendingKontaktTypeController: NancyModule
    {
        public StambladUdsendingKontaktTypeController(StambladUdsendingKontaktTypeService service)
        {
            Get("/udsendingKontaktTyper", o => service.GetStamBladUdsendingKontaktType());
        }
    }
}