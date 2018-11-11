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

        public StamData GetStamDataById(int bladId)
        {
           

            var res =  di.tblBladStamdatas.Where(r => r.BladID == bladId).FirstOrDefault();
            return dlu_persistence_api.mapper.AutoMaperUtil.ConvertFromTblStamBladEntity(res);
        }



    }
}
