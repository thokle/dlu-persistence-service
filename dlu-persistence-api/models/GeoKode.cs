using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
    public class GeoKode
    {
       
        public GeoKode()
        {
            this.tblBladStamdatas = new HashSet<StamData>();
        }

        public byte GeoKodeID { get; set; }
        public string GeoKodeNavn { get; set; }
        public byte GeoKodeSortKey { get; set; }
        public byte[] timestamp { get; set; }

        public virtual ICollection<StamData> tblBladStamdatas { get; set; }
    }
}
