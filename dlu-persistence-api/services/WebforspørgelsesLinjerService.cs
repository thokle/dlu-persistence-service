using System.Threading.Tasks;
using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class WebforspørgelsesLinjerService: IWebforspørgelsesLinjerService
    {
        private WEBForespørgselLinjerDao _dao;

        public WebforspørgelsesLinjerService()
        {
            using (_dao = new WEBForespørgselLinjerDao()) ;

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