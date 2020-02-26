using System;
using System.Data.Entity.Migrations;
using System.Linq;

namespace dlu_persistence_api.daos
{

    public class BladOphørtDao
    {

        private DiMPdotNetDevEntities entities;

        public BladOphørtDao()
        {
            entities = new DiMPdotNetDevEntities();
        }

        public OphørtBlad GetOphørtBlad(int bladid)
        {
            var res = from di in entities.tblOphørtBlad
                      where di.bladid == bladid
                      select new OphørtBlad()
                      {
                          bladid = di.bladid,
                          kommentart = di.kommentar,
                          ophørsdato = di.ophørsdato
                      };
            return res.SingleOrDefault<OphørtBlad>();
        }

        public int CreateOphørt(tblOphørtBlad tblOphørtBlad)
        {
            entities.tblOphørtBlad.AddOrUpdate(tblOphørtBlad);
            return entities.SaveChanges();
        }

    }

    public class OphørtBlad
    {
        public DateTime ophørsdato { get; internal set; }
        public string kommentart { get; internal set; }
        public int bladid { get; internal set; }
    }
}
