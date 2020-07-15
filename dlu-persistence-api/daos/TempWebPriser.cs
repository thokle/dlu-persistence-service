using System.Collections.Generic;

namespace dlu_persistence_api.daos
{
    public class TempWebPriser
    {

        public int BladID { get; set; }
        public decimal? Farve4Max { get;  set; }
        public decimal? Farve4Min { get;  set; }
        public decimal? Farve4Pris { get;  set; }
        public decimal? FarveMax { get;  set; }
        public decimal? FarveMin { get;  set; }
        public decimal? FarvePris { get;  set; }
        public int FormatFra { get;  set; }
        public int FormatTil { get;  set; }
        public decimal? mmPris { get;  set; }
        public byte PlaceringID { get;  set; }
        public int PrislisteID { get;  set; }
        public short year { get;  set; }
        public string PlaceringsNavn { get;  set; }
    }
}