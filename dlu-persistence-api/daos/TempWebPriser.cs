using System.Collections.Generic;

namespace dlu_persistence_api.daos
{
    internal class TempWebPriser
    {
        public List<tblPlacering> placeringer { get; internal set; }
        public decimal? Farve4Max { get; internal set; }
        public decimal? Farve4Min { get; internal set; }
        public decimal? Farve4Pris { get; internal set; }
        public decimal? FarveMax { get; internal set; }
        public decimal? FarveMin { get; internal set; }
        public decimal? FarvePris { get; internal set; }
        public int FormatFra { get; internal set; }
        public int FormatTil { get; internal set; }
        public decimal? mmPris { get; internal set; }
        public byte PlaceringID { get; internal set; }
        public int PrislisteID { get; internal set; }
        public short År { get; internal set; }
    }
}