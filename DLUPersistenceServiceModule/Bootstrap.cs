using Nancy.TinyIoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DLUPersistenceServiceModule
{
    public class Bootstrap : Nancy.DefaultNancyBootstrapper
    {
        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);

            container.Register<Newtonsoft.Json.JsonSerializer, CustomJsonSerializer>();
        }
    }

    public class CustomJsonSerializer : Newtonsoft.Json.JsonSerializer
    {
        public CustomJsonSerializer()
        {
            this.ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver();
           
        }
    }
}