using System.Threading.Tasks;
using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class EjerforholdService: IEjerforholdService
    {
        private EjerforholdDao _dao;
        public EjerforholdService()
        {
            _dao = new EjerforholdDao();
        }

        public Task<int> CreateOrUpDateEjerforhold(tblEjerforhold tblEjerforhold)
        {
            return _dao.OpretEjerforhold(tblEjerforhold);
        }

        public string GetAllEjerforhold()
        {
            return _dao.GetAllEjerforhold();
        }

        public string GetEjerForholdName(string name)
        {
            return _dao.GetEjerForholdName(name);
        }
    }
}