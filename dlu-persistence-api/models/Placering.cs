using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
    public class Placering
    {

        public Placering()
        {
            this.tblMedieplans = new HashSet<M>();
            this.Prisers = new HashSet<tblPriser>();
        }

        public byte PlaceringID { get; set; }
        public string Betegnelse { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMedieplan> tblMedieplans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prisers> Prisers { get; set; }
    }
}
