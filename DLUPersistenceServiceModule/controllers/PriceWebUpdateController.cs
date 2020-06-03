using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dlu_persistence_api.daos;
using Nancy;

namespace DLUPersistenceServiceModule.controllers
{
    public sealed class PriceWebUpdateController : NancyModule
    {
        public PriceWebUpdateController(): base("/priceWebUpdate")
        {
            Get("/{email}", func);
        }

        private object func(dynamic arg)
        {
            throw new NotImplementedException();
        }
    }
}