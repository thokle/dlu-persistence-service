using dlu_persistence_api.services;
using Nancy;


namespace DLUPersistenceServiceModule.controllers
{
    public sealed class NavisionContactController: NancyModule
    {
        public NavisionContactController(NavisiomContactService service)
        {
           Get("/navisionContact/byPersonId/{personId:string}", o =>   service.GetNavisionContactbySalesPersonId(o.personId));
        }
    }
}