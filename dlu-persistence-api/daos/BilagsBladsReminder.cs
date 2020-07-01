using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
    class BilagsBladsReminder
    {

        private DiMPdotNetDevEntities devEntities;

        public BilagsBladsReminder()
        {
            devEntities = new DiMPdotNetDevEntities();
        }

        public int CountBilagsBladsReminderes(int mediePlanNr, int ugeavisId)
        {try
            {
                return devEntities.tblRemindereSendts.Where(e => e.MedieplanNr == mediePlanNr).Where(uge => uge.UgeavisID == ugeavisId).Count();

            } catch(SqlException  ex)
            {
                throw new Exception(ex.Message);
            }



        }

        public int DeleteReminder(int mediePlanNr, int ugeavisID)
        {
            try
            {
                var deleteReminder = devEntities.tblRemindereSendts.Where(e => e.MedieplanNr == mediePlanNr).Where(uge => uge.UgeavisID == ugeavisID).FirstOrDefault();

                devEntities.tblRemindereSendts.Remove(deleteReminder);
                return devEntities.SaveChanges();

            }catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
                   }


        public int OpRetMediePlanNr(tblRemindereSendt tblRemindereSendt)
        {
            try
            {
                devEntities.tblRemindereSendts.AddOrUpdate(tblRemindereSendt);

                return devEntities.SaveChanges();
            } catch(EntityException ex)
            {
                throw new Exception(ex.Message);
            }
         
        }
    }
}
