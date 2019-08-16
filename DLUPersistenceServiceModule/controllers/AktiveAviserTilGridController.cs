using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using dlu_persistence_api.services;

namespace DLUPersistenceServiceModule.controllers
{
    public class AktiveAviserTilGridController: NancyModule
    {
        public AktiveAviserTilGridController(AktiveAviserTIlGridService  service)
        {
            Get("/AktiveAviser", o => service.GetAllAvisetTilGrid());
            Get("/AktiveAviser/by/{by}", o => service.getAktivAvisByNavn(o.by));
            Get("/AktiveAviser/daek/{daek}", o => service.getAktiveAvisByDaekningGrad(o.daej));
           
        }
    }
}