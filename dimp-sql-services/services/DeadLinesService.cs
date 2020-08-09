using dimp_sql_services.daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dimp_sql_services.services
{
       public   class DeadLinesService: IDeadLinesService
    {

        private DeadLinesDao dead;

        public DeadLinesService()
        {
            dead = new DeadLinesDao();
        }

        public int CreateDeadLine(tblWEBUdgivelse wEBUdgivelse)
        {
            return dead.CreateDeadLine(wEBUdgivelse: wEBUdgivelse);
        }

        public List<DeadLine> GetDeadLine(int bladid, int type)
        {
            return dead.GetDeadLine(bladid, type);
        }


    }
}
