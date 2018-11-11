using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
   public class Dage
    {
     
        public Dage()
        {
            this.tblBladStamdatas = new HashSet<StamData>();
            this.tblBladStamdatas1 = new HashSet<StamData>();
        }

        public byte DagID { get; set; }
        public string DagNavn { get; set; }
        public string DagType { get; set; }
        public byte[] timestamp { get; set; }

     
        public virtual ICollection<StamData> tblBladStamdatas { get; set; }
      
        public virtual ICollection<StamData> tblBladStamdatas1 { get; set; }
    }
}
