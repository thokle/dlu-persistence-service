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
    
    public partial class tblBemærkninger
    {
        public int OrdreNr { get; set; }
        public int BladID { get; set; }
        public string Bemærkning { get; set; }
    
        public virtual tblBladeOLD tblBladeOLD { get; set; }
        public virtual tblOrdrer tblOrdrer { get; set; }
    }
}
