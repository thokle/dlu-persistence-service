using System;

namespace dlu_persistence_api.models
{
    public class SkalSendes
    {
        private string nr;
        private int medieplanNr;
        private Int16 version;
        private string annoncørNo_;
        private string bureauNo_;
        private string format;
        private Byte antalFarver;
        private Byte indrykningsUge;
        private string ordreUdsendt;
        private string materialeFra;
        private string materialeUdsendt;
        private string ordreAnsvarlig;
        private string salgsAnsvarlig;
        private string overskrift;
        private string deadline;
        private string kommentar;

        public string Nr { get => nr; set => nr = value; }
        public int MedieplanNr { get => medieplanNr; set => medieplanNr = value; }
        public short Version { get => version; set => version = value; }
        public string AnnoncørNo_ { get => annoncørNo_; set => annoncørNo_ = value; }
        public string BureauNo_ { get => bureauNo_; set => bureauNo_ = value; }
        public string Format { get => format; set => format = value; }
        public byte AntalFarver { get => antalFarver; set => antalFarver = value; }
        public byte IndrykningsUge { get => indrykningsUge; set => indrykningsUge = value; }
        public string OrdreUdsendt { get => ordreUdsendt; set => ordreUdsendt = value; }
        public string MaterialeFra { get => materialeFra; set => materialeFra = value; }
        public string MaterialeUdsendt { get => materialeUdsendt; set => materialeUdsendt = value; }
        public string OrdreAnsvarlig { get => ordreAnsvarlig; set => ordreAnsvarlig = value; }
        public string SalgsAnsvarlig { get => salgsAnsvarlig; set => salgsAnsvarlig = value; }
        public string Overskrift { get => overskrift; set => overskrift = value; }
        public string Deadline { get => deadline; set => deadline = value; }
        public string Kommentar { get => kommentar; set => kommentar = value; }
    }
}