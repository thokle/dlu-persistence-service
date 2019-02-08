using System.Data.Entity.Core.Metadata.Edm;
using dlu_persistence_api;
using  dlu_persistence_api.services;
using  Nancy;
using Nancy.ModelBinding;
using Nancy.Responses;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class WebMailController: NancyModule
    {
        public WebMailController(WebMailService service):base("/webemail")
        {
            Get("/webforspørgelsesLinjer/email/{email:string}", o => service.GetWebMailByMail(o.email));
            Get("/webforspørgelsesLinjer/personnavn/{personnavn:string}", o => service.GetWebMailByPersonNavn(o.personnavn));
            Post("/webforspørgelsesLinjer/create", o =>
            {
                var web = this.Bind<tblWEBeMail>();

                return service.CreateOrUpdate(web);

            } );
        }
    }
}