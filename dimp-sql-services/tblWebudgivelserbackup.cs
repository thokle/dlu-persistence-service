//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dimp_sql_services
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblWebudgivelserbackup
    {
        public int ForespørgselID { get; set; }
        public byte Type { get; set; }
        public int OrdreNr { get; set; }
        public int AnnoncørID { get; set; }
        public string Mediebureau { get; set; }
        public int KonsulentID { get; set; }
        public byte AntalBlade { get; set; }
        public string Format { get; set; }
        public byte AntalFarver { get; set; }
        public byte Placering { get; set; }
        public byte AntalIndrykninger { get; set; }
        public Nullable<System.DateTime> SvarInden { get; set; }
        public bool Afsluttet { get; set; }
        public string Bemærkning { get; set; }
    }
}
