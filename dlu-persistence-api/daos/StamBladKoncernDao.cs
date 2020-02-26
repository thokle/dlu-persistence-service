using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace dlu_persistence_api.daos
{
    public class StamBladKoncernDao
    {
        private DiMPdotNetDevEntities entities;

        public StamBladKoncernDao()
        {
            entities = new DiMPdotNetDevEntities();
        }


        public List<Koncern> GetAllKoncers()
        {
            var res = (from k in entities.tblStambladKoncerns
                       orderby k.koncern_name ascending
                       select new Koncern
                       {
                           koncern_name = k.koncern_name
                       }).ToList<Koncern>();
            return res;
        }

        public int AddOrUpdate(tblStambladKoncern tbl)
        {
            entities.tblStambladKoncerns.AddOrUpdate(tbl);
            return entities.SaveChanges();

        }
    }

    public class Koncern
    {
        public Koncern()
        {
        }

        public string koncern_name { get; internal set; }
    }
}
