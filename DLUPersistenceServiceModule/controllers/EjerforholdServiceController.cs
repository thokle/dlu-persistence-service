using dlu_persistence_api;
using  Nancy;
using Nancy.ModelBinding;
using dlu_persistence_api.services;
namespace DLUPersistenceServiceModule.controllers
{
    public sealed class EjerforholdServiceController: NancyModule
    {
        public EjerforholdServiceController(EjerforholdService service) : base("ejerforhold")
        {
            Get("", o => { return service.GetEjerforold(); });
           
            Post("", o =>
            {
                var ejerforhold = this.Bind<tblEjerforhold>();
               return service.CreateOrUpDateEjerforhold(ejerforhold);
            } );
        }
        
        
    }
}