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
        }

        public StamData GetStamDataById(int bladId)       {
           

            var res =  di.tblBladStamdatas.Where(r => r.BladID == bladId).FirstOrDefault();
            return dlu_persistence_api.mapper.AutoMaperUtil.ConvertFromTblStamBladEntity(res);
        }

        public List<StamData> GetStamBladByName(String name, String order, Boolean asc)
        {
            var resultat = from m in di.tblBladStamdatas.Where(d => d.Navn.Contains(name)).OrderBy(s => s.Navn).ToList<tblBladStamdata>() select m;

           return 

            

        }



    }
}
