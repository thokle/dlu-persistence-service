using System.Collections.Generic;
using System.Linq;

namespace dlu_persistence_api.daos
{
    public class KoncernMiljøTillægDao
    {
        private DiMPdotNetDevEntities entities;

        public KoncernMiljøTillægDao()
        {
            entities = new DiMPdotNetDevEntities();

        }

        public int CreateMiljætilæg(tblKoncernMiljøTillæg tblKoncernMiljøTillæg)
        {
            entities.tblKoncernMiljøTillæg.Add(tblKoncernMiljøTillæg);
            return entities.SaveChanges();
        }

        public List<KoncernMiljøTillæg> GetkoncernMiljøTillægs()
        {
            var res = from km in entities.tblKoncernMiljøTillæg
                      orderby km.miljøtilæg
                      select new KoncernMiljøTillæg()
                      {
                          koncern = km.koncern,
                          miljøid = km.miljøid,
                          miljøtillæg = km.miljøtilæg
                      };

            return res.ToList();
        }


    }

    public class KoncernMiljøTillæg
    {
        public string koncern { get; internal set; }
        public int miljøid { get; internal set; }
        public decimal? miljøtillæg { get; internal set; }
    }
}
