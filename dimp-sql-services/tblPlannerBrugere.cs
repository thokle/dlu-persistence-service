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
    
    public partial class tblPlannerBrugere
    {
        public int brugerID { get; set; }
        public string Navn { get; set; }
        public string Login { get; set; }
        public string PassWord { get; set; }
        public string eMail { get; set; }
        public string Tlf { get; set; }
        public byte Status { get; set; }
    }
}