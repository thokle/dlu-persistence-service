using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.services.interfaces;
using dlu_persistence_api.daos;
namespace dlu_persistence_api.services
{
    public class AktiveAviserTIlGridService : IAktiveAviserTIlGridService
    {
        private AktiveAviserTIlGridDao gridDao;
        public AktiveAviserTIlGridService()
        {
            gridDao = new AktiveAviserTIlGridDao();
        }

        public string getAktivAvisByNavn(string navn)
        {
            return gridDao.getAktivAvisByNavn(navn);
        }

        public string getAktiveAvisByDaekningGrad(int daek)
        {
            return gridDao.getAktiveAvisByDaekningGrad(daek);
        }

        public string GetAllAvisetTilGrid()
        {
            return gridDao.GetAllAvisetTilGrid();
        }
    }
}
