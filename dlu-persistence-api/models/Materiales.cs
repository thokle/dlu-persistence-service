using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
    public class Materiales
    {

        public Materiales()
        {
            this.MedieplanLinjers = new HashSet<MedieplanLinjer>();
        }

        public int MedieplanNr { get; set; }
        public int UgeavisID { get; set; }
        public string FilNavn { get; set; }
        public bool ErSendt { get; set; }
        public bool SkalSendes { get; set; }
        public string FilSti { get; set; }

        public virtual tblMedieplanNr tblMedieplanNr { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedieplanLinjer> MedieplanLinjers { get; set; }
    }
}
