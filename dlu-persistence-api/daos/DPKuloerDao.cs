using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
  public  class DPKuloerDao
    {
        private DiMPdotNetDevEntities devEntities;

        public DPKuloerDao()
        {
            devEntities = new DiMPdotNetDevEntities();
        }

        public List<DPKulør> GetDPKuloer()
        {
            try
            {
                var res = from ku in devEntities.tblDPKulør
                          orderby ku.DPKulørID ascending
                          select new DPKulør()
                          {
                             DPKuloerId =  ku.DPKulørID, kuloer=  ku.Kulør
                                   
                          };
                return res.ToList();

            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
