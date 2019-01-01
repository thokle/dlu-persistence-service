using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
   public class FejlTekst
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FejlTekst()
        {
            this.tblAnnoncekontrols = new HashSet<Annoncekontrol>();
        }

        public byte Fejlkode { get; set; }
        public string Fekst { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<Annoncekontrol> tblAnnoncekontrols { get; set; }
    }
}
