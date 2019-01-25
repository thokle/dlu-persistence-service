using System.Threading.Tasks;
using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class EjerforholdService: IEjerforholdService
    {
        private EjeforholdDao _dao;
        public EjerforholdService()
        {
            _dao = new EjeforholdDao();
        }
   
        public string GetEjerforold()
        {
            return _dao.GetEjerforold();
        }

        public Task<int> CreateOrUpDateEjerforhold(tblEjerforhold tblEjerforhold)
        {
            return _dao.CreateOrUpDateEjerforhold(tblEjerforhold);
        }
    }
}