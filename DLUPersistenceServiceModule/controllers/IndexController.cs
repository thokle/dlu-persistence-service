using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace DLUPersistenceServiceModule.controllers
{
    public class IndexController : Nancy.NancyModule
    {
        public IndexController(dlu_persistence_api.daos.StamBladsDao stamBladDao) : base("/index")
        {
            Get("", parameter =>
            {

                return Response.AsJson(stamBladDao.GetStamDataById(2));

            });
    }
    }
}