using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
   public class Prisers
    {
        public int BladID { get; set; }
        public byte PlaceringID { get; set; }
        public short År { get; set; }
        public int PrislisteID { get; set; }
        public int FormatFra { get; set; }
        public int FormatTil { get; set; }
        public Nullable<decimal> mmPris { get; set; }
        public Nullable<decimal> FarvePris { get; set; }
        public Nullable<decimal> FarveMin { get; set; }
        public Nullable<decimal> FarveMax { get; set; }
        public Nullable<decimal> Farve4Pris { get; set; }
        public Nullable<decimal> Farve4Min { get; set; }
        public Nullable<decimal> Farve4Max { get; set; }
        public string ControlNavn { get; set; }

        public virtual tblBladStamdata tblBladStamdata { get; set; }
        public virtual tblPlacering tblPlacering { get; set; }
        public virtual tblPrislister tblPrislister { get; set; }
    }
}
