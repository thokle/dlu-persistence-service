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
    
    public partial class tblAnnoncører3år
    {
        public string AnnoncørID { get; set; }
        public string Annoncør { get; set; }
        public string Adresse { get; set; }
        public string PostNr { get; set; }
        public string Indehaver { get; set; }
        public string Tlf { get; set; }
        public string Fax { get; set; }
        public string CVRNr { get; set; }
        public Nullable<byte> BetalingsID { get; set; }
        public Nullable<int> FakturaSendesTil { get; set; }
        public Nullable<bool> Overført { get; set; }
        public Nullable<System.DateTime> OverførtTid { get; set; }
        public string Navn2 { get; set; }
        public string Adresse2 { get; set; }
        public string eMail { get; set; }
        public int SalgsAnsvarligID { get; set; }
        public string EANNr { get; set; }
        public bool SikGodt { get; set; }
        public bool InfGodt { get; set; }
        public bool Deaktiveret { get; set; }
        public string OmsætningsKode { get; set; }
        public string SalgsAnsvarligInitialer { get; set; }
    }
}
