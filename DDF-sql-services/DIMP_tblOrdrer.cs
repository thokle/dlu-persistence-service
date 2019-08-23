//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DDF_sql_services
{
    using System;
    using System.Collections.Generic;
    
    public partial class DIMP_tblOrdrer
    {
        public int OrdreNr { get; set; }
        public string AnnoncørID { get; set; }
        public Nullable<byte> Uge { get; set; }
        public Nullable<short> mm { get; set; }
        public Nullable<byte> mmType { get; set; }
        public string Format { get; set; }
        public Nullable<bool> FarveTillæg { get; set; }
        public Nullable<byte> AntalFarver { get; set; }
        public Nullable<System.DateTime> OrdreDato { get; set; }
        public Nullable<decimal> SamletPris { get; set; }
        public string Delområder { get; set; }
        public Nullable<System.DateTime> Oprettet { get; set; }
        public string Konsulent { get; set; }
        public Nullable<byte> SidstIndrykket { get; set; }
        public Nullable<bool> MaterialeVedlagt { get; set; }
        public string MaterialeFra { get; set; }
        public Nullable<bool> SkalSættes { get; set; }
        public string Kulør { get; set; }
        public Nullable<bool> MaterialeGodt { get; set; }
        public Nullable<bool> SikkerhedsGodt { get; set; }
        public Nullable<bool> InfoGodt { get; set; }
        public string BureauOrdreNr { get; set; }
        public string FakturaSendesTil { get; set; }
        public string Bureau { get; set; }
        public string BilagsBladSendesTil { get; set; }
        public string Bemærkning { get; set; }
        public Nullable<bool> EnOrdre { get; set; }
        public Nullable<byte> Status { get; set; }
        public string AttachedFile { get; set; }
        public string Overskrift { get; set; }
        public string HovedBlad { get; set; }
        public bool DanskeJob { get; set; }
        public Nullable<System.DateTime> OverførtTid { get; set; }
        public string FakBem1 { get; set; }
        public string FakBem2 { get; set; }
        public string FakBem3 { get; set; }
        public Nullable<bool> Udsendt { get; set; }
        public string Header1 { get; set; }
        public string Header2 { get; set; }
        public string Header3 { get; set; }
        public Nullable<byte> FilVersion { get; set; }
        public Nullable<bool> newFile { get; set; }
        public Nullable<bool> MatEjFakturerbar { get; set; }
        public bool MåGiFarveRabat { get; set; }
        public Nullable<int> OprindeligID { get; set; }
        public Nullable<bool> ErLåst { get; set; }
        public Nullable<byte> MaterialeStatus { get; set; }
        public string BilagsBladATT { get; set; }
        public Nullable<bool> MaterialeSat { get; set; }
        public Nullable<bool> SammeFil { get; set; }
        public Nullable<bool> SammeBureauNr { get; set; }
        public Nullable<bool> AlleSendt { get; set; }
        public Nullable<byte> Document_Type { get; set; }
        public Nullable<int> Previous_Order_No { get; set; }
        public string Credit_Reason { get; set; }
        public Nullable<int> Version { get; set; }
        public Nullable<int> Previous_Version { get; set; }
    }
}
