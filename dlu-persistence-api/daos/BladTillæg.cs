using System.Collections.Generic;
using System.Linq;
namespace dlu_persistence_api.daos
{
    public class BladTillæg
    {
        private DiMPdotNetDevEntities di = new DiMPdotNetDevEntities();
        public BladTillæg()
        {
            bladTillægsTypers = (from bt in di.tblBladTillaegsTypes
                                 select new BladTillægsTyper()
                                 {
                                     id = bt.id,
                                     type = bt.type
                                 }).ToList<BladTillægsTyper>();
        }

        public int? BladId { get; set; }
        public double? Pris { get; set; }
        public string type { get; set; }
        public List<BladTillægsTyper> bladTillægsTypers { get; set; }
        public bool? fastpris { get; set; }
        public bool? mmpris { get; set; }
    }
}