using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.services.interfaces;
using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class KommentartService 
    {
        private BladKommentarDao dao;

        public KommentartService()
        {
            dao = new BladKommentarDao();
        }
        public Task<int> CreateBladKommentar(tblBladKommentar tblBladKommentar)
        {
            return dao.CreateBladKommentar(tblBladKommentar);
        }

     
    }
}
