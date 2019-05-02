using dlu_persistence_api;
using  Nancy;
using Nancy.ModelBinding;
using dlu_persistence_api.services;
namespace DLUPersistenceServiceModule.controllers
{
    public sealed class EjerforholdController: NancyModule
    {
        public EjerforholdController(EjerforholdService service)
        {
            Get("/ejerforhold", o => { return service.GetAllEjerforhold(); });
           
            Post("ejerforhold/create", o =>
            {
                var ejerforhold = this.Bind<tblEjerforhold>();
               return service.CreateOrUpDateEjerforhold(ejerforhold);
            } );
        }
        
        
    }
}