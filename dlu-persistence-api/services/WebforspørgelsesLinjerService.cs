using dlu_persistence_api.daos;
using System.Threading.Tasks;
namespace dlu_persistence_api.services
{
    public class WebforspørgelsesLinjerService : IWebforspørgelsesLinjerService
    {
        private WEBForespørgselLinjerDao _dao;

        public WebforspørgelsesLinjerService()
        {
            _dao = new WEBForespørgselLinjerDao();

        }
        public string GetForspørgelsesLinjerByBladId(int bladID)
        {

            return _dao.GetForspørgelsesLinjerByBladId(bladID);
        }

        public Task<int> CreateOrUpdate(tblWEBForespørgselLinjer forespørgselLinjer)
        {
            return _dao.CreateOrUpdate(forespørgselLinjer);
        }
    }
}