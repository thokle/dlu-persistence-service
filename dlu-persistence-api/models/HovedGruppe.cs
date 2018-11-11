using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
   public class HovedGruppe
    {
      
        public HovedGruppe()
        {
            this.tblBladStamdatas = new HashSet<StamData>();
        }

        public byte HovedGruppeID { get; set; }
        public string HovedGruppeNavn { get; set; }
        public byte HovedGruppeSortKey { get; set; }
        public byte[] timestamp { get; set; }

        public virtual ICollection<StamData> tblBladStamdatas { get; set; }
    }
}
