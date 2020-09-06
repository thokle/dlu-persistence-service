using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
   public class FundneMediePlaner
    {
        private string nr;
        private string annoncørNo_;
        private string bureauNo_;
        private string beskrivelse;
        private string betegenelse;
        private string format;
        private byte antalfarver;
        private int antalUgeAviser;
        private string konsulentCode;
        private byte indrykningsUge;
        private byte status;
        private int medieplanNr;
        private int ugeAvisID;
        private Int16 version;
        private string overskrift;
        private bool rettelserEfterAnnoncekontrol;
        private string salgsAnsvarlig;
        private DateTime oprettetDato;

        public string Nr { get => nr; set => nr = value; }
        public string AnnoncørNo_ { get => annoncørNo_; set => annoncørNo_ = value; }
        public string BureauNo_ { get => bureauNo_; set => bureauNo_ = value; }
        public string Beskrivelse { get => beskrivelse; set => beskrivelse = value; }
        public string Betegenelse { get => betegenelse; set => betegenelse = value; }
        public string Format { get => format; set => format = value; }
        public byte Antalfarver { get => antalfarver; set => antalfarver = value; }
        public int AntalUgeAviser { get => antalUgeAviser; set => antalUgeAviser = value; }
        public string KonsulentCode { get => konsulentCode; set => konsulentCode = value; }
        public byte IndrykningsUge { get => indrykningsUge; set => indrykningsUge = value; }
        public byte Status { get => status; set => status = value; }
        public int MedieplanNr { get => medieplanNr; set => medieplanNr = value; }
        public Int16 Version { get => version; set => version = value; }
        public string Overskrift { get => overskrift; set => overskrift = value; }
        public bool RettelserEfterAnnoncekontrol { get => rettelserEfterAnnoncekontrol; set => rettelserEfterAnnoncekontrol = value; }
        public string SalgsAnsvarlig { get => salgsAnsvarlig; set => salgsAnsvarlig = value; }
        public DateTime OprettetDato { get => oprettetDato; set => oprettetDato = value; }
    }
}
