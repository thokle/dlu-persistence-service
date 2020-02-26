using dlu_persistence_api.services;
using Nancy;
namespace DLUPersistenceServiceModule.controllers
{
    public class DPKulorController : NancyModule
    {
        public DPKulorController(DPKuloerDaoService dP)
        {
            Get("/dpkuloer", o => dP.GetDPKuloer());

        }
    }
}