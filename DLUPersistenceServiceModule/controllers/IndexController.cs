﻿using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace DLUPersistenceServiceModule.controllers
{
    public sealed class IndexController : Nancy.NancyModule
    {
        public IndexController()
        {
         
            
            Get("/swagger/", _ =>
            {
          
                return Response.AsRedirect($"http://petstore.swagger.io/?url=http://localhost:5000/api-docs");
            });
            Get("/swagger-ui/",_=> { return Response.AsRedirect("http://localhost:5000/swagger-ui/"); });  
    }
    }
}