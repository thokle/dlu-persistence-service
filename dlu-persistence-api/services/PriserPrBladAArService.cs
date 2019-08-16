using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.daos;
using dlu_persistence_api.services.interfaces;

namespace dlu_persistence_api.services
{
    public class PriserPrBladAArService : IPriserPrBladAArService
    {

        private PriserBladPrAarDao _priserBladPr;

        public PriserPrBladAArService()
        {
            _priserBladPr = new PriserBladPrAarDao();
        }
        public Task<int> createPriceBladPrAAr(tblPrislisterPrBladPrÅr tblPrislisterPrBladPrÅr)
        {
            return _priserBladPr.createPriceBladPrAAr(tblPrislisterPrBladPrÅr);
        }

    }
    
    }

 

