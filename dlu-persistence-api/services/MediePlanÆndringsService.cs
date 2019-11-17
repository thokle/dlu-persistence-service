using System.Threading.Tasks;
using dlu_persistence_api.daos;
using dlu_persistence_api.models;
using System.Collections.Generic;
namespace dlu_persistence_api.services
{
    
    public class MediePlanÆndringsService
    {

        private MedieplanÆndringerDao _ændringerDao;

        public MediePlanÆndringsService()
        {
            _ændringerDao = new MedieplanÆndringerDao();
        }
        
        public List<AenderingsTekst> GetMediePlanÆndringerByMedieId(int mediePlan, int version)
        {
            return _ændringerDao.GetMediePlanÆndringerByMedieId(mediePlan, version);
        }

        public Task<int> CreateOrUpdate(tblMedieplanÆndringer tblMedieplanÆndringer)
        {
            return _ændringerDao.CreateOrUpdate(tblMedieplanÆndringer);
        }
    }
}