using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.services.interfaces;
using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class BladTillaegsTypeService : IBladTillaegsTypeService
    {
        private BladTillaegsTypeDao dao;

        public BladTillaegsTypeService()
        {
            dao = new BladTillaegsTypeDao();
        }
        public Task<int> CreateBladTillaegs(tblBladTiLaegsType tblBladTiLaegsType)
        {
            return dao.CreateBladTillaegs(tblBladTiLaegsType);
        }

        public string GetBladTilKLaegs(int bladid)
        {
            return dao.GetBladTilKLaegs(bladid);
        }
    }
}
