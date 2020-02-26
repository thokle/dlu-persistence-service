using dlu_persistence_api;
using dlu_persistence_api.services;
using Nancy;
using Nancy.ModelBinding;
namespace DLUPersistenceServiceModule.controllers
{
    public sealed class OrdreGebyrNavisionController : NancyModule
    {
        private string path = "/OrdreGebyrNavision/";
        public OrdreGebyrNavisionController(OrdreGebyrNavisionService service)
        {
            Get(path + "saelgerkode/saelgerkode:string}",
                o => service.GetOrderGebyNavisionBySælgerkode(o.saelgerkode));
            Get(path + "bureau/{bureau:string}", o => service.GetOrderNavisionGebyrByBureau(o.bureau));
            Get(path + "orderid/{orderid:int}", o => service.GetOrderGebyNavisionByOrderId(o.orderid));
            Post(path + "/create/", o =>
            {
                var res = this.Bind<tblOrdreGebyrNavision>();

                return service.CreateOrUpate(res);

            });
        }

    }
}