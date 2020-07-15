using dlu_persistence_api.daos;
using dlu_persistence_api.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
  public  class OmsaetningService
    {
        private OmsaetningDao dao;
        public OmsaetningService()
        {
            dao = new OmsaetningDao();
        }


        public List<Omsaetning> GetOmsaetnings(int år, int fraUge, int tilUge)
        {
            return dao.GetOmsaetnings(år, fraUge, tilUge);
        }
    }
}
