using dlu_persistence_api.daos;
using dlu_persistence_api.services.interfaces;
namespace dlu_persistence_api.services
{
    public class KontaktTitlerService : IKontaktTitlerService
    {
        private KontaktTitlerDao titlerDao;

        public KontaktTitlerService()
        {
            titlerDao = new KontaktTitlerDao();
        }

        public string GetTitler()
        {
            return titlerDao.GetTitler();
        }
    }
}
