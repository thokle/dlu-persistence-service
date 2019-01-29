using System.Threading.Tasks;
using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    
    public class MediePlanÆndringsService: IMediePlanÆndringerService
    {

        private MedieplanÆndringerDao _ændringerDao;

        public MediePlanÆndringsService()
        {
            _ændringerDao = new MedieplanÆndringerDao();
        }
        
        public string GetMediePlanÆndringerByMedieId(int mediePlan)
        {
            return _ændringerDao.GetMediePlanÆndringerByMedieId(mediePlan);
        }

        public Task<int> CreateOrUpdate(tblMedieplanÆndringer tblMedieplanÆndringer)
        {
            return _ændringerDao.CreateOrUpdate(tblMedieplanÆndringer);
        }
    }
}