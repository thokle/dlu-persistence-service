using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
   public  class MiljøtillægDao
    {
        private DiMPdotNetDevEntities entities;

        public MiljøtillægDao()
        {
            entities = new DiMPdotNetDevEntities();
                
        }

        public int OpretMiljøTilLæg(tblKoncernMiljøTillæg tbl)
        {
            entities.tblKoncernMiljøTillæg.Add(tbl);
            return entities.SaveChanges();
        }


    }
}
