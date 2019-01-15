using System.Threading.Tasks;
using  dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    
    public class MediePlanLinjerService: IMediePlanLinjerService
    {

        private MediePlanLinjerDao _dao;

        public MediePlanLinjerService()
        {
            _dao = new MediePlanLinjerDao();
        }
        public string GetMediePlanLinjerByMedieId(int medieoid)
        {
           return _dao.GetMediePlanLinjerByMediePlanId(medieId: medieoid);
        }

        public Task<int> CreateOrUpDate(tblMedieplanLinjer tblMedieplanLinjer)
        {
            return _dao.CreateOrUpdateMediePlanLinjer(tblMedieplanLinjer);
        }
    }
}