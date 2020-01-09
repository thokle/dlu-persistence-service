using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
   public class MediePlanLinjer
    {
        public int MedieplanNr { get; set; }
        public short Version { get; set; }
        public int UgeavisID { get; set; }
        public short Mm { get; set; }
        public decimal NormalMmPris { get; set; }
        public decimal MmPris { get; set; }
        public float MmRabat { get; set; }
        public Nullable<bool> MaaGiveMmRabat { get; set; }
        public decimal MmTotal { get; set; }
        public decimal FarveTillaeg { get; set; }
        public decimal FarvePris { get; set; }
        public float FarveRabat { get; set; }
        public decimal FarveMin { get; set; }
        public decimal FarveMax { get; set; }
        public decimal FarveTotal { get; set; }
        public decimal Total { get; set; }
        public bool MaaGiveMaterialeGodtgoerelse { get; set; }
        public bool SkalGiveMaterialeGodtgoerelse { get; set; }
        public decimal MaterialeGodtgoerelsePris { get; set; }
        public Nullable<decimal> TotalPris { get; set; }
        public bool ManueltAendret { get; set; }
        public bool ErWeekendGruppe { get; set; }
        public bool WebtillaegFaktureresHer { get; set; }
        public string SendeGruppe { get; set; }
        public string RabatGruppe { get; set; }
        public string MedIGrupper { get; set; }
        public string BureauOrdreNr { get; set; }
        public string MaterialeNr { get; set; }
        public string Bemaerkning { get; set; }
        public decimal MiljoeTillaeg { get; set; }
        public decimal TotalInclTillaeg { get; set; }
        public bool PrisLaast { get; set; }
        public bool? MaaGiveRabat { get; internal set; }
        public bool ManueltÆndret { get; internal set; }
        public decimal MaterialeGodtgørelsePris { get; internal set; }
        public decimal MiljøTillæg { get; internal set; }
        public bool MåGiveMaterialeGodtgørelse { get; internal set; }
    }
}
