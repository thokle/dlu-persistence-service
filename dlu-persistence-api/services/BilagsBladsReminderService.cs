using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api;
using dlu_persistence_api.daos;

namespace dlu_persistence_api.services
{
   public  class BilagsBladsReminderService
    {
        private BilagsBladsReminder bladsReminder;

        public BilagsBladsReminderService()
        {
            bladsReminder = new BilagsBladsReminder();
        }

        public int CountBilagsBladsReminderesf(int mediePlanNr, int ugeAvisId)
        {
            return bladsReminder.CountBilagsBladsReminderes(mediePlanNr, ugeAvisId);
        }

        public int DeleteReminder(int mediePlanNr, int ugeavisID)
        {
            return bladsReminder.DeleteReminder(mediePlanNr, ugeavisID);
        }

        public int OpRetMediePlanNr(tblRemindereSendt tblRemindereSendt)
        {
            return bladsReminder.OpRetMediePlanNr(tblRemindereSendt);
        }
    }
}
