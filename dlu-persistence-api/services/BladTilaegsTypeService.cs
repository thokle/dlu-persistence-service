using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.services.interfaces;
using dlu_persistence_api.daos;

namespace dlu_persistence_api.services
{
    public class BladTilaegsTypeService 
    {
        private BladTilaegsTypeDao dao;
        
        public BladTilaegsTypeService()
        {
            dao = new BladTilaegsTypeDao();
        }
        public int CreateOrUpdate(tblBladTillaegsType tblBladTillaegsType)
        {
            return dao.CreateOrUpdate(tblBladTillaegsType);
        }

      
    }
}

