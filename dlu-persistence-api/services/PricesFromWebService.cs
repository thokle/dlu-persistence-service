using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
   public class PricesFromWebService : IPricesFromWebService
    {
        private PricesFromWebDao webDao;

        public PricesFromWebService()
        {
            webDao = new PricesFromWebDao();
        }

        public List<PriceTilWeb> ShowPapersFromStamBladId(string stamBladEmail)
        {
            return webDao.ShowPapersFromStamBladId(stamBladEmail);
        }

        public Boolean UpdatePrisTilWeb(PriceWebUpdate priceWebUpdate)
        {
            return webDao.UpdatePrisTilWeb(priceWebUpdate);
        }
    }
}
