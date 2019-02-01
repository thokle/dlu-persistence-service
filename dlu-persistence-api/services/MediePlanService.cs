using System.Threading.Tasks;
using  dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class MediePlanService: IMediePlanService
    {
        private MediePlanDao _mediePlanDao;

        public MediePlanService()
        {
            _mediePlanDao =  new MediePlanDao();
           
        }
        public string GetMediePlanById(int id)
        {
            return _mediePlanDao.GetMediePlanByNumber(id);
        }

        public string GetMediePlanByKontakt(string name)
        {
            return _mediePlanDao.getMediePlanByKontaktPerson(name);
        }

        public Task<int> CreateOrUpdate(tblMedieplan tblMedieplan)
        {
            return _mediePlanDao.CreateOrUpdateMediePlan(tblMedieplan);

        }
    }
}