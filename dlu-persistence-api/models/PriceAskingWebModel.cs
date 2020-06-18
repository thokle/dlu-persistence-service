using DDF_sql_services;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
    class PriceAskingWebModel
    {
        private int _forespørgselID;
        private int _type;
        private int _medieplanNr;
        private string _name;
        private string _mediebureau;
        private string _onsulentCode;
        private int _antalBlade;
        private string _format;
        private byte _afsluttet;
        private string _BemærkningM;
        public int ForespørgselID { get => _forespørgselID; set => _forespørgselID = value; }
        public int Type { get => _type; set => _type = value; }
        public int MedieplanNr { get => _medieplanNr; set => _medieplanNr = value; }
        public string Name { get => _name; set => _name = value; }
        public string Mediebureau { get => _mediebureau; set => _mediebureau = value; }
        public string OnsulentCode { get => _onsulentCode; set => _onsulentCode = value; }
        public int AntalBlade { get => _antalBlade; set => _antalBlade = value; }
        public string Format { get => _format; set => _format = value; }
        public byte Afsluttet { get => _afsluttet; set => _afsluttet = value; }
        public string BemærkningM { get => _BemærkningM; set => _BemærkningM = value; }
    }
}
