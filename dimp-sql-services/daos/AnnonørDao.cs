using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dimp_sql_services.daos
{
    public class AnnonørDao
    {
        private dimpSQLEntities dimpSQLEntities;

        public AnnonørDao()
        {
            dimpSQLEntities = new dimpSQLEntities();
            dimpSQLEntities.Configuration.LazyLoadingEnabled = true;
        }


      
    }
}
