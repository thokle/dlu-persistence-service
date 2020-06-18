using Newtonsoft.Json;
using System;
using System.Linq;

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

        public DLUContact getDLUContact(string contactnr)
        {
            try
            {
                var res = from dlucontac in entities1.DLU_Contact where dlucontac.Bill_to_Contact_No_ == contactnr select new DLUContact {
                
                
                
                };

                return res.FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }

    public class DLUContact
    {
    }
}
