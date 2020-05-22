using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class MediePlanStatusHelperService
    {
        private MediePlanStatusHelper MediePlanStatusHelper;

        public MediePlanStatusHelperService()
        {
            MediePlanStatusHelper = new MediePlanStatusHelper();
        }


        public Tuple<int, int, int> UpdateStatusOnMediePlanAsync(int mediePlan, int status)
        {
            return MediePlanStatusHelper.UpdateStatusOnMediePlanAsync(mediePlan, status);
        }
    }

}
