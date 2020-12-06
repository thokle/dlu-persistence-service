using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.services
{
    public class ErSendtDaoService
    {

        private dlu_persistence_api.daos.ErSendtDao erSendtDao;

        public ErSendtDaoService()
        {
            erSendtDao = new daos.ErSendtDao();
        }

        public List<models.SkalSendes> GetAllSkalSendes()
        {
            try
            {
               return erSendtDao.GetAllSkalSendes();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<models.SkalSendes> GetSkalSendesFraUgeTilUge(int fraUge, int tilUge)
        {
            try
            {
                return erSendtDao.GetSkalSendesFraUgeTilUge(fraUge, tilUge);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
