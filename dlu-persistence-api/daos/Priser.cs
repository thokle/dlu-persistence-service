using System.Linq;
using System.Collections.Generic;
namespace dlu_persistence_api.daos
{
    public class Priser
    {
       
        private DiMPdotNetDevEntities di;
        public Priser()
        {
            di = new DiMPdotNetDevEntities();
            placerings = (from pl in di.tblPlacerings
                      select new Placering()
                      {
                          Betegenlse = pl.Betegnelse, PlaceringID = pl.PlaceringID
                      }).ToList<Placering>();
                    
        }
        public short År { get; set; }
        public int BladID { get; set; }
        public string ControlNavn { get; set; }
        public decimal? Farve4Max { get; set; }
        public decimal? Farve4Min { get; set; }
        public decimal? Farve4Pris { get; set; }
        public decimal? FarveMax { get; set; }
        public decimal? FarveMin { get; set; }
        public decimal? FarvePris { get; set; }
        public int FormatFra { get; set; }
        public int FormatTil { get; set; }
        public byte PlaceringID { get; set; }
        public int PrislisteID { get; set; }
        public decimal? mmPris { get; set; }
        public string placering { get; set; }
        public List<Placering> placerings { get; set; }
        public string Betegnelse { get;  set; }
        public string PrislisteNavn { get;  set; }
    }

    public class Placering
    {
        public Placering()
        {
        }

        public string Betegenlse { get; set; }
        public byte PlaceringID { get; set; }
    }
}