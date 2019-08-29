using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using dlu_persistence_api.services;
namespace DLUPersistenceServiceModule.controllers
{
    public class DPKulorController: NancyModule
    {
     public DPKulorController(DPKuloerDaoService dP) {
            Get("/dpkuloer", o => dP.GetDPKuloer());

        }   
    }
}