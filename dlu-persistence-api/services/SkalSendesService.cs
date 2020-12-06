using dlu_persistence_api.daos;
using dlu_persistence_api.exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public    class SkalSendesService
    {
        SkalSendesDao sendesDao;

        public SkalSendesService()
        {
            sendesDao = new SkalSendesDao();
        }


        public List<models.SkalSendes> SkaSendes()
        {
            try
            {
                return sendesDao.SkaSendes();

            }
            catch (FormattedDbEntityValidationException ex)
            {

                throw new Exception(ex.HelpLink);
            }

        }

        public List<models.SkalSendes> SkalSendesByUge(int fraUge, int tilUge)
        {
            try
            {
                return sendesDao.SkalSendesByUge(fraUge, tilUge);
            }
            catch (FormattedDbEntityValidationException ex)
            {
                throw new Exception(ex.HelpLink);
            }
        }


    }
}

