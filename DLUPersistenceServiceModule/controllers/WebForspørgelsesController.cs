using dlu_persistence_api;
using dlu_persistence_api.services;
using Nancy;
using Nancy.ModelBinding;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class WebForspørgelsesController : NancyModule
    {
        public WebForspørgelsesController(WenForspørgelsesService service) : base("/")
        {

            Get("/webforspørgelses/mediplannr/{medieplannr:int", o => service.GetWebForespørgselByMedieplanNr(o.medieplannr));
            Get("/webforspørgelses/medieburea/{bureau:string}", o => service.GetWebForespørgselByMediebureau(o.bureau));
            Get("/webforspørgelses/annoncor/{annoncor:string}", o => service.GetWebForespørgselByAnnoncørNo(o.annoncor));
            Post("/webforspørgelses/create", o =>
            {

                var res = this.Bind<tblWEBForespørgsel>();

                return service.CreateOrUpdate(res);

            });
        }
    }
}