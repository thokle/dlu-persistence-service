using System.Diagnostics;
using System.Threading.Tasks;
using  dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class StambladKontaktPersonService: IStambladKontaktPersonService
    {
        private StambladKontaktPersonDao dao;

        public StambladKontaktPersonService()
        {
            dao = new StambladKontaktPersonDao();
        }
        public string GetKontaktPersonerByBladID(int bladId)
        {
            return dao.GetKontaktPersonerByBladID(bladId: bladId);
        }

        public Task<int> CreateOrUpdateKontaktPerson(StamBladKontaktPersoner personer)
        {
            return dao.CreateOrUpdateKontaktPerson(personer);
        }
    }
}