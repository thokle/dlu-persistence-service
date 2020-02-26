using dlu_persistence_api.services;
using Nancy;

namespace DLUPersistenceServiceModule.controllers
{
    public class AktiveAviserTilGridController : NancyModule
    {
        public AktiveAviserTilGridController(AktiveAviserTIlGridService service)
        {
            Get("/AktiveAviser", o => service.GetAllAvisetTilGrid());
            Get("/AktiveAviser/by/{by}", o => service.getAktivAvisByNavn(o.by));
            Get("/AktiveAviser/daek/{daek}", o => service.getAktiveAvisByDaekningGrad(o.daej));

        }
    }
}