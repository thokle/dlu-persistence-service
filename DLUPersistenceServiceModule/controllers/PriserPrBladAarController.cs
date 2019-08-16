using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using dlu_persistence_api.services;
using dlu_persistence_api;

namespace DLUPersistenceServiceModule.controllers
{
    public class PriserPrBladAarController: NancyModule
    {
        public PriserPrBladAarController(PriserPrBladAArService priser)
        {
            Get("/praarpriser/{bladid}/{prislisteId}/{aar}", o =>
           {
               tblPrislisterPrBladPrÅr b = new tblPrislisterPrBladPrÅr();
               b.BladID = o.bladid;
               b.PrislisteID = o.prislisteId;
               b.År = o.aar;
            
               return priser.createPriceBladPrAAr(b);
           });
        }

        
    }
}