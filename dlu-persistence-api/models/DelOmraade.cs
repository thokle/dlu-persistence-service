using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
   public  class DelOmraade
    {
       
        public DelOmraade()
        {
            this.tblBladStamdatas = new HashSet<StamData>();
        }

        public byte DelOmrådeID { get; set; }
        public string DelOmrådeKode { get; set; }
        public string DelOmrådeNavn { get; set; }
        public byte DelOmrådeSortKey { get; set; }
        public byte[] timestamp { get; set; }

        public ICollection<StamData> tblBladStamdatas { get; set; }
    }
}

