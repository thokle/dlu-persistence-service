using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.services.interfaces;
using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class KontaktTitlerService : IKontaktTitlerService
    {
        private KontaktTitlerDao titlerDao;

        public KontaktTitlerService()
        {
            titlerDao = new KontaktTitlerDao();
        }

        public string GetTitler()
        {
            return titlerDao.GetTitler();
        }  
    }
}
