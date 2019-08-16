using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
   public class PriserBladPrAarDao
    {
        private DiMPdotNetDevEntities netEntities;

        public PriserBladPrAarDao()
        {
            netEntities = new DiMPdotNetDevEntities();
            netEntities.Configuration.LazyLoadingEnabled = true;
            netEntities.Configuration.ValidateOnSaveEnabled = true;
            
        }

        public Task<int> createPriceBladPrAAr(tblPrislisterPrBladPrÅr tblPrislisterPrBladPrÅr)
        {
            
            netEntities.tblPrislisterPrBladPrÅr.Add(tblPrislisterPrBladPrÅr);
            return netEntities.SaveChangesAsync();
        }
    }
}
