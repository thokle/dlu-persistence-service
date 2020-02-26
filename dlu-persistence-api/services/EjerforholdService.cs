using dlu_persistence_api.daos;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace dlu_persistence_api.services
{
    public class EjerforholdService
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

        public List<EjerForhold> GetAllEjerforhold()
        {
            return _dao.GetAllEjerforhold();
        }


    }
}