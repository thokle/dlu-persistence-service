using dlu_persistence_api.daos;
using System;
using System.Collections.Generic;

namespace dlu_persistence_api.services
{
    public interface IPricesFromWebService
    {



        List<PriceTilWeb> ShowPapersFromStamBladId(string stamBladEmail);


        Boolean UpdatePrisTilWeb(PriceWebUpdate priceWebUpdate);
       
    }
}