using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.daos;
using dlu_persistence_api.models;

namespace dlu_persistence_api.services
{
    public class RevenueService
    {
        private RevenueDao RevenueDao;

        public RevenueService()
        {
            RevenueDao = new RevenueDao();
        }

        public Revenue GetRevenue(int uge, int aar)
        {
            try
            {
                return RevenueDao.GetRevenue(uge, aar);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
