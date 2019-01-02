using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
    public class MediePlanNr
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MediePlanNr()
        {
            this.tblMateriales = new HashSet<tblMateriale>();
            this.Medieplans = new HashSet<MediePlan>();
        }

        public int MedieplanNr { get; set; }
        public short AktivVersion { get; set; }
        public byte Status { get; set; }
        public bool SupportBilagVedlagt { get; set; }
        public bool SupportBilagVist { get; set; }
        public string FakturaBemærkning1 { get; set; }
        public string FakturaBemærkning2 { get; set; }
        public string FakturaBemærkning3 { get; set; }
        public bool MaterialeModtaget { get; set; }
        public byte BrugtGruppeVersion { get; set; }
        public bool OverførtFraPrisforespørgsel { get; set; }
        public decimal AnvendtMiljøTillæg { get; set; }
        public byte AnvendtPrisberegningVersion { get; set; }
        public string Kommentar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMateriale> tblMateriales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MediePlan> Medieplans { get; set; }
    }
}
