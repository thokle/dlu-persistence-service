using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace DLUPersistenceServiceModule.controllers
{
    public class IndexController : Nancy.NancyModule
    {
        public IndexController(dlu_persistence_api.daos.StamBladsDao stamBladDao) : base("/")
        {
            Get("", parameter => { return "Welcome to LokalPlanner API"; });
    }
    }
}