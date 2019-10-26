using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
   public class PrislisteDao
    {
        private DiMPdotNetDevEntities entities;

        public PrislisteDao()
        {
            entities = new DiMPdotNetDevEntities();
        }

        public int OpretPrisliste(tblPrislister tbl)
        {
            entities.tblPrislisters.AddOrUpdate(tbl);
            return entities.SaveChanges();
        }
    }
}
