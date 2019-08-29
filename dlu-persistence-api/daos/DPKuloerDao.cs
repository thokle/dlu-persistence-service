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

        public string GetDPKuloer()
        {
            try
            {
                var res = from ku in devEntities.tblDPKulør
                          orderby ku.DPKulørID ascending
                          select new
                          {
                             DPKuloerId =  ku.DPKulørID, kuloer=  ku.Kulør
                                   
                          };
                return JsonConvert.SerializeObject(res, Formatting.Indented);

            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
