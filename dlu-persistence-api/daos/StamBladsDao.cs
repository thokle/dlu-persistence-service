using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
    public class StamBladsDao
    {

        private DiMPdotNetEntities di;

        public StamBladsDao()
        {
            di = new DiMPdotNetEntities();
            di.Configuration.LazyLoadingEnabled = true;

        }

        public string GetStamDataById(int bladId)
        {

            var res = from en in di.tblBladStamdatas
                      where en.BladID == bladId join d
                      select new StamData()
                      {            
                          BladID = en.BladID,
                  
                        
                         tblPrislis(),
                          
                         tblPrislisterPrBladPrUges = en.tblPrislisterPrBladPrUges
                          
                      }; 



            return JsonConvert.SerializeObject(res);
        }


        public List<StamData> GetStamBladByName(String name, String order, Boolean asc)
        {
            var resultat = from m in di.tblBladStamdatas.Where(d => d.Navn.Contains(name)).OrderBy(s => s.Navn).ToList<tblBladStamdata>() select m ;

            return mapper.AutoMaperUtil.ConvertFromTblBladEntitie(resultat.ToList());

        }


        public StamData OpretNytStamBlad(StamData stamData)
        {
            try
            {

                var tblStamBladData = mapper.AutoMaperUtil.ConvertFromnStamData(stamData);
                var res = di.tblBladStamdatas.Add(tblStamBladData);

                return mapper.AutoMaperUtil.ConvertFromTblStamBladEntity(res);
            } catch( Exception e)
            {
                throw e;
            }
        }

        
    }

}
