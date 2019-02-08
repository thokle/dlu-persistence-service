using dlu_persistence_api;
using  dlu_persistence_api.services;
using  Nancy.ModelBinding;

using Nancy;
namespace DLUPersistenceServiceModule.controllers
{
    public sealed class WEBSendTilKollegaController: NancyModule
    {
        public WEBSendTilKollegaController(WEBSendTilKollegaService service)
        {
            Get("/webSendTIlKollega/personId/{personid:int}", o => service.WEBSendTilKollegaDaoByBladID(o.personid));
            Get("/webSendTIlKollega/bladId/{bladId:int}", o => service.WEBSendTilKollegaDaoByBladID(o.bliadId));
            Get("/webSendTIlKollega/email/{email:string}",  o => service.WEBSendTilKollegaDaoByeMails(o.email));
            Post("/webSendTIlKollega/create", o =>
            {

                var res = this.Bind<tblWEBSendTilKollega>();

                return service.CreateOrUpdata(res);
            });
        }
    }
}