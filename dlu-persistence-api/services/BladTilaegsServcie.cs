using dlu_persistence_api.daos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public class BladTilaegsServcie
    {
        private BladTilaegsDao dao;

        public BladTilaegsServcie()
        {
            dao = new BladTilaegsDao();
        }
        public Task<int> CreateOrUpdate(tblBladTillaeg tblBladTillaeg)
        {
            return dao.CreateOrUpdate(tblBladTillaeg);
        }

        public List<BladTill?g> GetTillaegsTypeByBladId(int bladid)
        {

            return dao.GetTillaegsTypeByBladId(bladid);
        }
    }
}
