using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
    public  class Annoncekontrol
    {


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Annoncekontrol()
        {
            MedieplanLinjers = new HashSet<MedieplanLinjer>();
        }

        public int MedieplanNr { get; set; }
        public int UgeavisID { get; set; }
        public bool ErKontrolleret { get; set; }
        public System.DateTime KontrolTidspunkt { get; set; }
        public string KontrollørEmail { get; set; }
        public bool KontrolleretAfDLU { get; set; }
        public byte Fejlkode { get; set; }
        public string Ansvar { get; set; }
        public string IndrykketPåSide { get; set; }
        public string FaktureresTil { get; set; }
        public byte SidePlacering { get; set; }

        public  tblFejlTekst tblFejlTekst { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<MedieplanLinjer>  MedieplanLinjers { get; set; }
    }
}
