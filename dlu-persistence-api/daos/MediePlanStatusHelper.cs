using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
     class MediePlanStatusHelper
    {
        private DiMPdotNetDevEntities devEntities;
 
        public MediePlanStatusHelper()
        {
            devEntities = new DiMPdotNetDevEntities();
        }

        public  Tuple<int, int, int> UpdateStatusOnMediePlanAsync(int mediePlan, int status)
        {
            var task1 = devEntities.Database.ExecuteSqlCommand("update tblMedieplanNr set Status=@status where MedieplanNr=@mediePlan  ", new SqlParameter("mediePlan", mediePlan), new SqlParameter("status", status));
            var task2 = devEntities.Database.ExecuteSqlCommand("update tblMedieplan set Status=@status where MedieplanNr=@mediePlan ", new SqlParameter("mediePlan", mediePlan), new SqlParameter("status", status));
           // var task3 = devEntities.Database.ExecuteSqlCommand("update tblMedieplanLinjer set Status=@status where MedieplanNr=@mediePlan", new SqlParameter("mediePlan", mediePlan), new SqlParameter("status", status));

          
                return new Tuple<int, int, int>(mediePlan, task1, task2);
            

        }
    }
}
