using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDF_sql_services.daos
{
   public class DLUContactDao
    {
        private DDFEntities entities1;
        
        public DLUContactDao()
        {
            entities1 = new DDFEntities();
            entities1.Configuration.LazyLoadingEnabled = true;
        }

        public string getDLUContact()
        {
            try
            {
                var res = from dlucontac in entities1.DLU_Contact select new { };

                return JsonConvert.SerializeObject(res,  Formatting.Indented, new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
