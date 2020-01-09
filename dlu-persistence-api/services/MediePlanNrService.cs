using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using dlu_persistence_api.daos;
using dlu_persistence_api.models;

namespace dlu_persistence_api.services
{
    public class MediePlanNrService
    {

        private MediaPlanNrDao MediaPlanNrDao;

        public MediePlanNrService()
        {
            MediaPlanNrDao = new MediaPlanNrDao();
        }

    public List<MediePlanNr> GetMediePlanNrByMedIePlanNr(int mediePlannr)
        {
            return MediaPlanNrDao.GetMediePlanNrDaoByMedPlanId(mediePlanId: mediePlannr);
        }

       public  Tuple<int,int, short>  CreateOrUpDateMediePlanNr(tblMedieplanNr tblMedieplanNr)
        {
            return MediaPlanNrDao.CreateOrUpDateMediePlanNr(tblMedieplanNr);
        }
    }
}