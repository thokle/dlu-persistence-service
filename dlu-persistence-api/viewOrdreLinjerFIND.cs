//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dlu_persistence_api
{
    using System;
    using System.Collections.Generic;
    
    public partial class viewOrdreLinjerFIND
    {
        public int OrdreNr { get; set; }
        public short Version { get; set; }
        public byte Document_Type { get; set; }
        public int BladId { get; set; }
        public string Format { get; set; }
        public short Mm { get; set; }
        public decimal AnvendtPris { get; set; }
        public float SpecialRabat { get; set; }
        public decimal FarveTillægsPris { get; set; }
        public float FarveTillægsRabat { get; set; }
        public bool MaterialeGodt { get; set; }
        public Nullable<decimal> TotalPris { get; set; }
        public decimal MaterialePris { get; set; }
    }
}
