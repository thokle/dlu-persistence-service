using dimp_sql_services.daos;
using System.Collections.Generic;

namespace models
{
    public class EjerforholdDeadLine
    {
        public string Navn { get;  set; }
        public List<DeadLine> Deadliens { get;  set; }
    }
}