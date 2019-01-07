using System;

using System.Linq;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{
    public class PriserDao
    {

        private DiMPdotNetEntities di;
        public PriserDao()
        {
            di = new DiMPdotNetEntities();
        }


        public string GetPrislisterPrÅrByBladId(int bladid)
        {

            var res = from p in di.tblPrislisterPrBladPrÅr
                      where p.BladID == bladid
                      select new
                      {
                          tblPrislister = from ps in di.tblPrisers where ps.BladID == bladid select new { }
                      };
            return JsonConvert.SerializeObject(res);
        }
    }
}
