using System.Threading.Tasks;
using dlu_persistence_api.daos;
using dlu_persistence_api.models;
using System.Collections.Generic;
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

        public List<EjerForhold>  GetAllEjerforhold()
        {
            return _dao.GetAllEjerforhold();
        }

      
    }
}