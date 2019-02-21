using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace DLUPersistenceServiceModule.controllers
{
    public sealed class IndexController : Nancy.NancyModule
    {
        public IndexController(dlu_persistence_api.daos.StamBladsDao stamBladDao)
        {
         
            Get("/swagger/", _ =>
            {
          
                return Response.AsRedirect($"http://petstore.swagger.io/?url=http://localhost:5000/api-docs");
            });
            Get("/swagger-ui",_=>  
            {                              
                var url = $"{Request.Url.BasePath}/api-docs";  
                return View["doc", url];  
            });  
    }
    }
}