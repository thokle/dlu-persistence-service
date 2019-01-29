using dlu_persistence_api.services;
using dlu_persistence_api;
using Nancy.ModelBinding;
using  Nancy;
namespace DLUPersistenceServiceModule.controllers
{
    public sealed class KontakterPrBladController: NancyModule
    {
        public KontakterPrBladController(KontakterPrBladService service): base("/kontakterPrBlad")
        {

            Post("", o =>
            {

                var rez = this.Bind<tblKontakterPrBlad>();


                return service.CreateOrUpdateKontakterPrBlad(rez);

            });
        }
    }
}