using dlu_persistence_api;
using  dlu_persistence_api.services;
using Nancy;
using  Nancy.ModelBinding;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class WebForspørgelsesController: NancyModule
    {
        public WebForspørgelsesController(WenForspørgelsesService service) : base("/webforspørgelses")
        {
            
            Get("/mediplannr/{medieplannr:int", o => service.GetWebForespørgselByMedieplanNr(o.medieplannr));
            Get("/medieburea/{bureau:string}", o => service.GetWebForespørgselByMediebureau(o.bureau));
            Get("/annoncor/{annoncor:string}", o => service.GetWebForespørgselByAnnoncørNo(o.annoncor));
            Post("/create", o =>
            {

                var res = this.Bind<tblWEBForespørgsel>();

                return service.CreateOrUpdate(res);

            });
        }
    }
}