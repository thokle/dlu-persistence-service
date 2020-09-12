using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
   public class WebForspørgelses
    {
        private int forespørgselID;
        private Byte type;
        private int medieplanNr;
        private string name;
        private string mediebureau;
        private string konsulentCode;
        private Byte antalBlade;
        private string format;
        private string betegnelse;
        private Byte antalFarver;
        private Byte antalIndrykninger;
        private DateTime svarInden;
        private Boolean afsluttet;
        private string bemærkning;

        public int ForespørgselID { get => forespørgselID; set => forespørgselID = value; }
        public byte Type { get => type; set => type = value; }
        public int MedieplanNr { get => medieplanNr; set => medieplanNr = value; }
        public string Name { get => name; set => name = value; }
        public string Mediebureau { get => mediebureau; set => mediebureau = value; }
        public string KonsulentCode { get => konsulentCode; set => konsulentCode = value; }
        public byte AntalBlade { get => antalBlade; set => antalBlade = value; }
        public string Format { get => format; set => format = value; }
        public string Betegnelse { get => betegnelse; set => betegnelse = value; }
        public byte AntalFarver { get => antalFarver; set => antalFarver = value; }
        public byte AntalIndrykninger { get => antalIndrykninger; set => antalIndrykninger = value; }
        public DateTime SvarInden { get => svarInden; set => svarInden = value; }
        public bool Afsluttet { get => afsluttet; set => afsluttet = value; }
        public string Bemærkning { get => bemærkning; set => bemærkning = value; }
    }
}
