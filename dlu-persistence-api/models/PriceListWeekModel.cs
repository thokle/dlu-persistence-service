using System.Linq;
using System.Collections.Generic;
using dlu_persistence_api.daos;

namespace dlu_persistence_api.models
{
    public class PriceListWeekModel
    {
        private int prislisteID;
        private int uige;
        private int aAr;
        private int bladID;
        private string navn;
        private List<daos.Prislister> prislisters;

        private DiMPdotNetDevEntities di;
        public PriceListWeekModel()
        {
            di = new DiMPdotNetDevEntities();
            prislisters = (from pl in di.tblPrislisters select new daos.Prislister()
            {
            PrislisteID =   pl.PrislisteID , PrislisteNavn = pl.PrislisteNavn
       
            }).ToList<daos.Prislister>();
        }
        public int PrislisteId
        {
            get => prislisteID;
            set => prislisteID = value;
        }

        public int Uige
        {
            get => uige;
            set => uige = value;
        }

        public int AAr
        {
            get => aAr;
            set => aAr = value;
        }

        public int BladId
        {
            get => bladID;
            set => bladID = value;
        }
        public string Navn { get => navn; set => navn = value; }
        public List<Prislister> Prislisters { get => prislisters; set => prislisters = value; }
    }
}