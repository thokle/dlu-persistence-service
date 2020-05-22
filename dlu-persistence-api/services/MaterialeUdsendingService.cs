using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
   public class MaterialeUdsendingService
    {
        private MateraleøudsendingDao materaleøudsendingDao;
        public MaterialeUdsendingService()
        {
            materaleøudsendingDao = new MateraleøudsendingDao();
        }

        public List<SendMateriale> GetSendMateriales(int medieplan, int version)
        {
            return materaleøudsendingDao.GetSendMateriales(medieplan, version);
        }
    }
}
