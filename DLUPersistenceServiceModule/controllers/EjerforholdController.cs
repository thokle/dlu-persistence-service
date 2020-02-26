using dlu_persistence_api;
using dlu_persistence_api.services;
using Nancy;
using Nancy.ModelBinding;
namespace DLUPersistenceServiceModule.controllers
{
    public sealed class EjerforholdController : NancyModule
    {
        public EjerforholdController(EjerforholdService service)
        {
            Get("/ejerforhold", o => { return service.GetAllEjerforhold(); });

            Post("ejerforhold/create", o =>
            {
                var ejerforhold = this.Bind<tblEjerforhold>();
                return service.CreateOrUpDateEjerforhold(ejerforhold);
            });
        }


    }
}