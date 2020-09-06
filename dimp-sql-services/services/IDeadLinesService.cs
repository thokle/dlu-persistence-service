using dimp_sql_services.daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dimp_sql_services.services
{
  public   interface IDeadLinesService
    {

        List<DeadLine> GetDeadLine(int bladid, int type);
        int CreateDeadLine(DeadLine wEBUdgivelse);
        int Delete(int bladid, int linje);
    }
}
