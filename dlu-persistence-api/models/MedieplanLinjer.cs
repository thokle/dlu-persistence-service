using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
    public class MedieplanLinjer
    {
        
        public int MedieplanNr { get; set; }
        public short Version { get; set; }
        public int UgeavisID { get; set; }
        public short Mm { get; set; }
        public decimal NormalMmPris { get; set; }
        public decimal MmPris { get; set; }
        public float MmRabat { get; set; }
        public Nullable<bool> MåGiveMmRabat { get; set; }
        public decimal MmTotal { get; set; }
        public decimal FarveTillæg { get; set; }
        public decimal FarvePris { get; set; }
        public float FarveRabat { get; set; }
        public decimal FarveMin { get; set; }
        public decimal FarveMax { get; set; }
        public decimal FarveTotal { get; set; }
        public decimal Total { get; set; }
        public bool MåGiveMaterialeGodtgørelse { get; set; }
        public bool SkalGiveMaterialeGodtgørelse { get; set; }
        public decimal MaterialeGodtgørelsePris { get; set; }
        public Nullable<decimal> TotalPris { get; set; }
        public bool ManueltÆndret { get; set; }
        public bool ErWeekendGruppe { get; set; }
        public bool WebtillægFaktureresHer { get; set; }
        public string SendeGruppe { get; set; }
        public string RabatGruppe { get; set; }
        public string MedIGrupper { get; set; }
        public string BureauOrdreNr { get; set; }
        public string MaterialeNr { get; set; }
        public string Bemærkning { get; set; }
        public decimal MiljøTillæg { get; set; }
        public decimal TotalInclTillæg { get; set; }
        public bool PrisLåst { get; set; }

        public virtual tblAnnoncekontrol tblAnnoncekontrol { get; set; }
        public virtual tblBladStamdata tblBladStamdata { get; set; }
        public virtual tblMateriale tblMateriale { get; set; }
        public virtual tblMedieplan tblMedieplan { get; set; }
    }
}
