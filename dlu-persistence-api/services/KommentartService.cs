using dlu_persistence_api.daos;
using System.Threading.Tasks;
namespace dlu_persistence_api.services
{
    public class KommentartService
    {
        private BladKommentarDao dao;

        public KommentartService()
        {
            dao = new BladKommentarDao();
        }
        public Task<int> CreateBladKommentar(tblBladKommentar tblBladKommentar)
        {
            return dao.CreateBladKommentar(tblBladKommentar);
        }


    }
}
