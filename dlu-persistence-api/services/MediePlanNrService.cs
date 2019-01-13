using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class MediePlanNrService: IMediePlanNrService
    {

        private MediaPlanNrDao MediaPlanNrDao;

        public MediePlanNrService()
        {
            MediaPlanNrDao = new MediaPlanNrDao();
        }

    public string GetMediePlanNrByMedIePlanNr(int mediePlannr)
        {
            return MediaPlanNrDao.GetMediePlanNrDaoByMedPlanId(mediePlanId: mediePlannr);
        }
    }
}