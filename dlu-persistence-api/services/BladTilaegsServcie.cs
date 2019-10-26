using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.services.interfaces;
using dlu_persistence_api.daos;

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

        public List<BladTillæg> GetTillaegsTypeByBladId(int bladid)
        {

            return dao.GetTillaegsTypeByBladId(bladid);
        }
    }
}
