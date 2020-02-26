using dlu_persistence_api.daos;
using System.Collections.Generic;
namespace dlu_persistence_api.services
{
    public class DPKuloerDaoService
    {
        private DPKuloerDao kuloerDao;

        public DPKuloerDaoService()
        {
            kuloerDao = new DPKuloerDao();
        }
        public List<DPKulør> GetDPKuloer()
        {
            return kuloerDao.GetDPKuloer();
        }
    }
}
