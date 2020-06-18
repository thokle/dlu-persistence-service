using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dlu_persistence_api.services;
using Nancy;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class PriceWebUpdateController : NancyModule
    {
        public PriceWebUpdateController(PricesFromWebService pricesFromWebService): base("/priceWebUpdate")
        {
            Get("/{email:string}", s =>
            {
                return pricesFromWebService.ShowPapersFromStamBladId(s.email);
            });
        }

       
    }
}