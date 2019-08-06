using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.services.interfaces;
using dlu_persistence_api.daos;

namespace dlu_persistence_api.services
{
    public class BladTilaegsTypeService : IBladTilaegsTypeService
    {
        private BladTilaegsTypeDao dao;
        
        public BladTilaegsTypeService()
        {
            dao = new BladTilaegsTypeDao();
        }
        public Task<int> CreateOrUpdate(tblBladTillaegsType tblBladTillaegsType)
        {
            return dao.CreateOrUpdate(tblBladTillaegsType);
        }

        public string GetBladtillaegsTyper()
        {
            return dao.GetBladtillaegsTyper();
        }
    }
}

