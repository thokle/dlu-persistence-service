using dimp_sql_services.daos;
using dlu_persistence_api.exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dimp_sql_services.services
{
    public class DeadLinesService : IDeadLinesService
    {

        private DeadLinesDao dead;

        public DeadLinesService()
        {
            dead = new DeadLinesDao();
        }

        public int CreateDeadLine(DeadLine wEBUdgivelse)
        {
            return dead.CreateDeadLine(wEBUdgivelse);
        }

        public int Delete(int bladid, int linje)
        {
            try
            {
                return dead.Delete(bladid, linje);
            }
            catch (FormattedDbEntityValidationException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<DeadLine> GetDeadLine(int bladid, int type)
        {
            return dead.GetDeadLine(bladid, type);
        }

        public List<models.EjerforholdDeadLine> GetEjerforholdDeadLines(string ejerforhold)
        {
            try
            {
                return dead.GetEjerforholdDeadLines(ejerforhold);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.InnerException.Message, ex.InnerException);
            }
        }
    }

}
