using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using dlu_persistence_api.services;
namespace DLUPersistenceServiceModule.controllers
{
    public class KontaktTilerController: NancyModule
    {
        public KontaktTilerController(KontaktTitlerService service)
        {
            Get("/kontaktTitler", o => service.GetTitler());
        }
    }
}